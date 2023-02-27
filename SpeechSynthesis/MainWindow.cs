/* 
   Copyright (C) Damien Golding
   
   This is free software; you can redistribute it and/or
   modify it under the terms of the GNU Library General Public
   License as published by the Free Software Foundation; either
   version 2 of the License, or (at your option) any later version.
   
   This library is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   Library General Public License for more details.
   
   You should have received a copy of the GNU Library General Public
   License along with this software; if not, write to the Free
   Software Foundation, Inc., 59 Temple Place - Suite 330, Boston,
   MA 02111-1307, USA

  Don't use it to find and eat babies ... unless you're really REALLY hungry ;-)

*/


using System;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;

using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using System.Media;
using System.Text;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Numerics;
using System.Security.Cryptography;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace SpeechSynthesis
{
    public partial class MainWindow : Form, IDisposable
    {
        private bool writeToFile = false;
        private bool documentDirty = false;
        private string selectedVoice = string.Empty;
        private string fileToWrite = string.Empty;
        private string documentFileName = string.Empty;
        string textToSynthesize = string.Empty;
        string userHomeDirectory = string.Empty;
        List<string> mru = new List<string>();
        string[] args;
        private bool showCompletionMessage = false;
        private Thread? speakThread = null;

        private SpeechSynthesizer synth = new SpeechSynthesizer();
        public MainWindow(string[] a)
        {
            InitializeComponent();
            this.FormClosing += MainWindowFormClosing;

            args = a;
            if (args.Length == 1 && File.Exists(args[0]))
            {
                documentFileName = args[0];
            }
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            getRegistry();
            processingToolStripProgressBar.Visible = false;
            outputDeviceComboBox.SelectedIndex = 0;
            getInstalledVoices();
            populateMru();

            if(!string.IsNullOrEmpty(documentFileName))
            {
                openFileInTextBox();
            }
        }

        private void MainWindowFormClosing(object? sender, FormClosingEventArgs e)
        {
            //if (speakThread != null)
            //{
            //    // MessageBox.Show("Text synthesis is not running.\r\nAble to exit Text to Speech", "Synthesis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return (false);
            //}
            if (!checkReadyForExit())
            {
                MessageBox.Show("Text synthesis is still running.\r\nUnable to exit Text to Speech", "Synthesis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel= true;
                return;
            }
            setRegistry();
        }
        private void setRegistry()
        {
            string root = "HKEY_CURRENT_USER\\SOFTWARE\\Golding's Gym\\SpeechSynthesis\\";
            if (string.IsNullOrEmpty(userHomeDirectory))
            {
                Registry.SetValue(root, "USER_HOME_DIR", "%USERPROFILE%");
            }
            else
            {
                Registry.SetValue(root, "USER_HOME_DIR", userHomeDirectory);
            }
            Registry.SetValue(root, "MRU", String.Join(",", mru));


        }
        private void getRegistry()
        {
            string root = "HKEY_CURRENT_USER\\SOFTWARE\\Golding's Gym\\SpeechSynthesis\\";
            string temp = (string)Registry.GetValue(root,"MRU",string.Empty);
            if (!string.IsNullOrEmpty(temp))
            {
                mru = temp.Split(",").ToList();
            }

            temp = (string)Registry.GetValue(root, "USER_HOME_DIR", string.Empty);
            if (!string.IsNullOrEmpty(temp))
            {
                userHomeDirectory = temp;
            }
        }
        private async void saveText()
        {
            if (!documentDirty)
            {
                return;
            }

            if ( string.IsNullOrEmpty( documentFileName))
            {
                saveTextAs();
            }

            else
            {
                try
                {
                    await File.WriteAllTextAsync(documentFileName, inputText.Text);
                    documentDirty = false;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("Speech synthesizer - {0}", documentFileName);
                    Text = sb.ToString();
                    documentDirty = false;
                    saveButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception saving file: " + ex.Message, "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                saveAvailableToolStripStatusLabel.Text = "Save unavailable";
            }
        }
        private async void saveTextAs()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Speech script files (*.spscr) | *.spscr";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string temp = sfd.FileName;
                    if (string.IsNullOrEmpty(temp))
                    {
                        MessageBox.Show("Error with file name:\r\n" + temp, "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    documentFileName = temp;
                    try
                    {
                        await File.WriteAllTextAsync(documentFileName, inputText.Text);
                        documentDirty = false;
                        StringBuilder sb = new StringBuilder();
                        sb.AppendFormat("Speech synthesizer - {0}", documentFileName);
                        Text = sb.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception saving file: " + ex.Message, "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    documentDirty = false;
                    saveAvailableToolStripStatusLabel.Text = "Save unavailable";
                    documentNameToolStripStatusLabel.Text = documentFileName;
                    saveButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception saving file: " + ex.Message, "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = userHomeDirectory;
            ofd.Filter = "Speech script files (*.spscr) | *.spscr";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string temp = ofd.FileName;
                if (string.IsNullOrEmpty(temp))
                {
                    MessageBox.Show("Failed to read file:\r\n" + temp, "Open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    saveText();
                    documentFileName = ofd.FileName;
                }
            }
            else
            {
                return;
            }
            openFileInTextBox();
        }

        void populateMru()
        {
            mruComboBox.Items.Clear();
            mruComboBox.Items.Add("Recently used files");
            foreach(string f in mru)
            {
                mruComboBox.Items.Add(f);
            }
            mruComboBox.SelectedIndex = 0;
        }

        private void startSynthesis(object sender)
        {
            if (sender is null)
            {
                return;
            }
            
            if ( string.IsNullOrEmpty( inputText.Text))
            {
                MessageBox.Show("The input field is empty", "Start synthesis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(writeToFile && string.IsNullOrEmpty( fileToWrite))
            {
                MessageBox.Show("No output file is specified", "Start synthesis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(sender is System.Windows.Forms.Button)
            {
                Button b = sender as Button;
                textToSynthesize = (string)b?.Tag == "run all" ? inputText.Text : inputText.SelectedText;
            }
            else if (sender is System.Windows.Forms.ToolStripMenuItem)
            {
                ToolStripMenuItem t = sender as ToolStripMenuItem;
                textToSynthesize = (string)t?.Tag == "run all" ? inputText.Text : inputText.SelectedText;
            }
           
            synth.SelectVoice(this.selectVoiceComboBox.Text);
            if (writeToFile)
            {
                showCompletionMessage = true;
                synth.SetOutputToWaveFile(fileToWrite);
            }
            else
            {
                showCompletionMessage = false;
                synth.SetOutputToDefaultAudioDevice();
            }

            if (string.IsNullOrEmpty( textToSynthesize))
            {
                MessageBox.Show("Input text is specified\r\nEither choose \'Run all\'\r\nor select a portion of text ", "Start synthesis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            runToolStripMenuItem.Enabled = false;
            runSelectedToolStripMenuItem.Enabled = false;

            speakThread = new Thread(
                () =>
                {
                    try
                    {
                        doSynthesis();
                    }
                    finally
                    {
                        completeSynthesis(synth);
                    }

                });
            speakThread.Start();
            processingToolStripProgressBar.Visible = true;
            if (writeToFile)
                MessageBox.Show("Completed writing wav file to:\r\n"+fileToWrite,"Speech generation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void completeSynthesis(SpeechSynthesizer synth)
        {
            processingToolStripProgressBar.Visible = false;
            synth.SetOutputToNull();
            speakThread = null;
            if (showCompletionMessage)
            {
                MessageBox.Show(this, "Completed text to voice synthesis", "Synthesis");
            }
            runToolStripMenuItem.Enabled = true;
            runSelectedToolStripMenuItem.Enabled = true;
        }

        private void doSynthesis()
        {
            synth.Volume = 100;
            synth.Speak(textToSynthesize);
        }

        private void StatusDialog_RaiseCancelCalled(object? sender, EventArgs e)
        {
            //statusDialog.Close();
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            saveButton.Enabled = true;
            saveAvailableToolStripStatusLabel.Text = "Save available";
        }

        private void outputDeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outputDeviceComboBox.Text.ToLower() == ".wav file")
            {
                outputFilelabel.Enabled=true;
                outputFileTextBox.Enabled = true;
                outputFileSelectorButton.Enabled = true;
                writeToFile = true;
            }
            else
            {
                outputFilelabel.Enabled = false;
                outputFileTextBox.Enabled = false;
                outputFileSelectorButton.Enabled = false;
                writeToFile = false;
            }
        }

        private void getInstalledVoices()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    selectVoiceComboBox.Items.Add(info.Name);
                }
                selectVoiceComboBox.SelectedIndex = 0;
            }
        }

        private void outputFileSelectorButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "wav files (*.wav) | *.wav";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                outputFileTextBox.Text = sfd.FileName;
                fileToWrite = sfd.FileName;
            }
        }

        private void selectVoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVoice = selectVoiceComboBox.Text;
        }

        private void showInstalledVoicesButton_Click(object sender, EventArgs e)
        {
            InstalledVoicesDialog ivd = new InstalledVoicesDialog();
            ivd.ShowDialog();
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            saveAvailableToolStripStatusLabel.Text = "Save available";

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startSynthesis(sender);
        }

        private void runSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startSynthesis(sender);
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            documentDirty = true;
            if ( string.IsNullOrEmpty( documentFileName))            {
                Text = "Speech synthesizer - [untitled] *";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat( "Speech synthesizer - {0} *", documentFileName);
                Text = sb.ToString();
            }
            saveButton.Enabled = true;
            saveAvailableToolStripStatusLabel.Text = "Save available";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveText();
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            saveTextAs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveText();
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTextAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkReadyForExit())
            {
                System.Windows.Forms.Application.Exit();
            }

        }

        bool checkReadyForExit()
        {
            bool ret = true;
            if (speakThread != null)
            {
                // MessageBox.Show("Text synthesis is not running.\r\nAble to exit Text to Speech", "Synthesis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return (false);
            }
            if (documentDirty )
            {
                DialogResult dr = MessageBox.Show("Would you like to save the current document?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
                if (dr == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(documentFileName))
                    {
                        saveTextAs();
                    }
                    else
                    {
                        saveText();
                    }
                    return (true);
                }
                else if(dr == DialogResult.No)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }

            return (ret);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.ShowDialog();
        }

        new public void Dispose()
        {
            if(synth != null)
                synth.Dispose();

        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                //MessageBox.Show("Ctl+shift+S", "Key down");
                saveAsButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                //MessageBox.Show("Ctl+S", "Key down");
                saveButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                //MessageBox.Show("Ctl+D", "Key down");
                clearButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                //MessageBox.Show("Ctl+X", "Key down");
                this.Close();
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                //MessageBox.Show("Ctl+O", "Key down");
                //openButton_Click(sender,e);
                openFile();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                //MessageBox.Show("Ctl+O", "Key down");
                newFileButton_Click(sender, e);
            }
        }

        private void mruComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp = mruComboBox.Text;
            if (tmp.ToLower() == "recently used files")
            {
                mruComboBox.SelectedIndex = 0;
            }
            else
            {
                if (documentDirty)
                {
                    saveText();
                }
                if (File.Exists(mruComboBox.Text)) {
                    documentFileName = mruComboBox.Text;
                    //openFile();
                    openFileInTextBox();
                }
                else
                {
                    MessageBox.Show( string.Format("The file located at:\r\n{0}\r\nNo longer exists",mruComboBox.Text), "File open",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    if(mru.Contains(mruComboBox.Text))
                    {
                        mru.Remove(mruComboBox.Text);
                        setRegistry();
                        populateMru();
                    }
                }
            }
        }

        private void openFileInTextBox()
        {
            inputText.Text = File.ReadAllText(documentFileName);
            documentDirty = false;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Speech synthesizer - {0}", documentFileName);
            Text = sb.ToString();
            saveButton.Enabled = false;
            saveAvailableToolStripStatusLabel.Text = "Save unavailable";
            documentNameToolStripStatusLabel.Text = documentFileName;
            if (!mru.Contains(documentFileName))
            {
                mru.Add(documentFileName);
                setRegistry();
                populateMru();
            }
        }

        private void newFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = sfd.Filter = "Speech script files (*.spscr) | *.spscr";
            sfd.Title = "New Speech script file";
            DialogResult dr = sfd.ShowDialog(); 
            if (dr == DialogResult.OK)
            {
                documentFileName= sfd.FileName;
            }
            else
            {
                return;
            }

            saveText();
            clearButton_Click(sender, e);
            saveText();
            saveAsButton.Enabled = true;
            saveButton.Enabled = false;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Speech synthesizer - {0}", documentFileName);
            Text = sb.ToString();
            documentDirty= false;
            saveAvailableToolStripStatusLabel.Text = "Save unavailable";
            documentNameToolStripStatusLabel.Text = documentFileName;
            mru.Add(documentFileName);
            setRegistry();
            populateMru();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFileButton_Click(sender, e);
        }

        private void clearMRUBbutton_Click(object sender, EventArgs e)
        {
            mru.Clear();
            mruComboBox.Items.Clear();
            mruComboBox.Items.Add("Recently used files");
            mruComboBox.SelectedIndex= 0;
        }
    }
}