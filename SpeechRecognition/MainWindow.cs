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


using SpeechSynthesis;
using System.Speech.Recognition;

namespace SpeechRecognition
{    
    public partial class MainWindow : Form, IDisposable
    {
        private SpeechRecognitionEngine? recog = null;
        private bool documentDirty = false;
        private string documentFileName = string.Empty;
        RecognizerInfo? ri = null;
        public MainWindow()
        {
            InitializeComponent();
            InitRecog();
            LoadGrammars();
            ri = LoadRecognizers();
            this.FormClosing += MainWindowFormClosing;
        }

        new public void Dispose()
        {
            if (recog != null)
            {
                recog.Dispose();
            }
        }

        private void InitRecog()
        {
            GoldingsGymGrammar g = new GoldingsGymGrammar();
            recog = null;
            recog = new SpeechRecognitionEngine(
               new System.Globalization.CultureInfo("en-GB")
               //ri
                );
            recog.LoadGrammar(g);
            DictationGrammar dg = new DictationGrammar();
            recog.LoadGrammar(dg);
            recog.LoadGrammar(new GoldingsGymGrammar());

            recog.SetInputToDefaultAudioDevice();
            recog.BabbleTimeout = TimeSpan.FromSeconds((int)babbleTimeout.Value);
            recog.InitialSilenceTimeout = TimeSpan.FromSeconds((int)initialSilenceTimeout.Value);
            //recog.EndSilenceTimeout = TimeSpan.FromSeconds(3);
            recog.RecognizeCompleted += RecogRecognizeCompleted;
            recog.SpeechRecognized += RecogSpeechRecognized;
        }

        private void RecogSpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result == null)
            {
                outputText.Text += "Watchoo talkin' about Willis?";
            }
            else
            {
                outputText.Text += e.Result.Text + "\r\n";
            }
        }

        private void RecogRecognizeCompleted(object? sender, RecognizeCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                outputText.Text += "Watchoo talkin' about Willis?";
            }
            else
            {
                //outputText.Text += e.Result.Text + "\r\n";
            }
            activateButton.Enabled = true;
            deactivateButton.Enabled = false;
            MessageBox.Show("The capture has completed.\r\nClick the 'Activate' button to re-start.", "Capture complete");
            InitRecog();

        }
        private void MainWindowFormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!CheckReadyForExit(sender,e))
            {
                MessageBox.Show("Text synthesis is still running.\r\nUnable to exit Text to Speech", "Synthesis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }
        }
        private bool CheckReadyForExit(object? sender, FormClosingEventArgs e)
        {
            if (documentDirty)
            {
                DialogResult dr = MessageBox.Show("Would you like to save the current document?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(documentFileName))
                    {
                        saveTextAsToolStripButton_Click(sender!, e);
                    }
                    else
                    {
                        saveTextToolStripButton_Click(sender!, e);
                    }
                    return (true);
                }
                else if (dr == DialogResult.No)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }

            }

            return (true);
        }
        private void LoadGrammars()
        {
            var grammars = recog!.Grammars;
            //MessageBox.Show("Grammar count: " + grammars.Count, "Grammar");
            foreach (var grammar in grammars)
            {
                if (string.IsNullOrEmpty(grammar.Name))
                    continue;
                //MessageBox.Show("Grammar name: " + grammar.Name, "Grammar");
                grammarsComboBox.Items.Add(grammar.Name);
            }
            //grammarsComboBox.SelectedIndex = 0;
            
        }
        private RecognizerInfo? LoadRecognizers()
        {
            var recogs = SpeechRecognitionEngine.InstalledRecognizers();
            //MessageBox.Show("Recognizer count: " + recogs.Count, "recogs");
            foreach (var r in recogs)
            {
                //MessageBox.Show("recogniser name: " + r.Name, "recogs");
                if (r.Culture.TwoLetterISOLanguageName.Equals("en"))
                {
                    //MessageBox.Show(r.Culture.Name, "Data");
                    return (r);
                }
            }
            return (null);
        }

        private void ActivateRecog()
        {
            if (recog != null)
            {
                outputText.Text += "recog != null . . .\r\n";
                recog.RecognizeAsync(RecognizeMode.Multiple);
                outputText.Text += "recog is recognising . . .\r\n";
            }
            else
            {
                InitRecog();
                if(recog != null)
                    recog.RecognizeAsync(RecognizeMode.Multiple);
            }
            
        }

        private void completeRecog(object sender, RecognizeCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                outputText.Text += e.Result.Text;
            }
            else
            {
                outputText.Text += "Watchoo talkin' about Willis";
            }

        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            deactivateButton.Enabled = true;
            activateButton.Enabled = false;
            Text = "Speech recognition - processing";
            processingToolStripProgressBar.Visible = true;
            ActivateRecog();
        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Click on deactivate button");
            recog!.RecognizeAsyncStop();
            deactivateButton.Enabled = false;
            activateButton.Enabled = true;
            Text = "Speech recognition - idle";
            processingToolStripProgressBar.Visible = false;
            System.Diagnostics.Debug.WriteLine("Leaving now . . .");
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {
            documentDirty = true;
            saveAvailableToolStripStatusLabel.Text = "Save available";
            if (string.IsNullOrEmpty(outputText.Text))
            {
                clearOutputToolStripButton.Enabled = false;
            }
            else
            {
                saveTextAsToolStripButton.Enabled = true;
                saveTextToolStripButton.Enabled = true;
                clearOutputToolStripButton.Enabled = true;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //saveTextAsToolStripButton.
        }

        private async void saveTextToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!documentDirty)
                {
                    return;
                }
                if (string.IsNullOrEmpty(documentFileName))
                {
                    saveTextAsToolStripButton_Click(sender, e);
                    return;
                }
                string s = outputText.Text;
                await File.WriteAllTextAsync(documentFileName, outputText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Exception:\r\n{0}", ex.ToString()), "File save error");
                documentDirty = true;
                documentFileName = string.Empty;
            }
            documentNameToolStripStatusLabel.Text = documentFileName;
            saveAvailableToolStripStatusLabel.Text = "Save unavailable";
            saveTextToolStripButton.Enabled = false;
            documentDirty = false;
        }

        private void saveTextAsToolStripButton_Click(object sender, EventArgs e)
        {
            try{ 
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text files (*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    documentFileName = sfd.FileName;
                    saveTextToolStripButton_Click(sender, e);
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Exception:\r\n{0}", ex.ToString()), "File save error");
            }
        }

        private void clearOutputToolStripButton_Click(object sender, EventArgs e)
        {
            outputText.Text = string.Empty;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.S) {
                // MessageBox.Show("Ctl+shift+S", "Key down");
                saveTextAsToolStripButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                // MessageBox.Show("Ctl+S", "Key down");
                saveTextToolStripButton_Click(sender,e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                //MessageBox.Show("Ctl+D", "Key down");
                clearOutputToolStripButton_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                // MessageBox.Show("Ctl+X", "Key down");
                this.Close();
            }

        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.ShowDialog();
        }
    }
}
