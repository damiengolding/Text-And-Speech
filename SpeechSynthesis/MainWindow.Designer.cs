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


namespace SpeechSynthesis
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputDevicelabel = new System.Windows.Forms.Label();
            this.outputDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.outputFilelabel = new System.Windows.Forms.Label();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileSelectorButton = new System.Windows.Forms.Button();
            this.selectVoiceLabel = new System.Windows.Forms.Label();
            this.selectVoiceComboBox = new System.Windows.Forms.ComboBox();
            this.showInstalledVoicesLabel = new System.Windows.Forms.Label();
            this.showInstalledVoicesButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.saveAvailableToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.documentNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.processingToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mruComboBox = new System.Windows.Forms.ComboBox();
            this.newFileButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearMRUBbutton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputText.Location = new System.Drawing.Point(12, 144);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputText.Size = new System.Drawing.Size(1210, 420);
            this.inputText.TabIndex = 13;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // outputDevicelabel
            // 
            this.outputDevicelabel.AutoSize = true;
            this.outputDevicelabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputDevicelabel.Location = new System.Drawing.Point(8, 53);
            this.outputDevicelabel.Name = "outputDevicelabel";
            this.outputDevicelabel.Size = new System.Drawing.Size(100, 19);
            this.outputDevicelabel.TabIndex = 0;
            this.outputDevicelabel.Text = "Output device:";
            // 
            // outputDeviceComboBox
            // 
            this.outputDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDeviceComboBox.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputDeviceComboBox.FormattingEnabled = true;
            this.outputDeviceComboBox.Items.AddRange(new object[] {
            "Default audio device",
            ".wav file"});
            this.outputDeviceComboBox.Location = new System.Drawing.Point(114, 53);
            this.outputDeviceComboBox.Name = "outputDeviceComboBox";
            this.outputDeviceComboBox.Size = new System.Drawing.Size(291, 27);
            this.outputDeviceComboBox.TabIndex = 1;
            this.outputDeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.outputDeviceComboBox_SelectedIndexChanged);
            // 
            // outputFilelabel
            // 
            this.outputFilelabel.AutoSize = true;
            this.outputFilelabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputFilelabel.Location = new System.Drawing.Point(787, 56);
            this.outputFilelabel.Name = "outputFilelabel";
            this.outputFilelabel.Size = new System.Drawing.Size(79, 19);
            this.outputFilelabel.TabIndex = 0;
            this.outputFilelabel.Text = "Output file:";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputFileTextBox.Location = new System.Drawing.Point(872, 53);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(309, 26);
            this.outputFileTextBox.TabIndex = 3;
            // 
            // outputFileSelectorButton
            // 
            this.outputFileSelectorButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputFileSelectorButton.Location = new System.Drawing.Point(1187, 51);
            this.outputFileSelectorButton.Name = "outputFileSelectorButton";
            this.outputFileSelectorButton.Size = new System.Drawing.Size(29, 29);
            this.outputFileSelectorButton.TabIndex = 4;
            this.outputFileSelectorButton.Text = "...";
            this.outputFileSelectorButton.UseVisualStyleBackColor = true;
            this.outputFileSelectorButton.Click += new System.EventHandler(this.outputFileSelectorButton_Click);
            // 
            // selectVoiceLabel
            // 
            this.selectVoiceLabel.AutoSize = true;
            this.selectVoiceLabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectVoiceLabel.Location = new System.Drawing.Point(411, 53);
            this.selectVoiceLabel.Name = "selectVoiceLabel";
            this.selectVoiceLabel.Size = new System.Drawing.Size(87, 19);
            this.selectVoiceLabel.TabIndex = 0;
            this.selectVoiceLabel.Text = "Select voice:";
            // 
            // selectVoiceComboBox
            // 
            this.selectVoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectVoiceComboBox.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectVoiceComboBox.FormattingEnabled = true;
            this.selectVoiceComboBox.Location = new System.Drawing.Point(515, 53);
            this.selectVoiceComboBox.Name = "selectVoiceComboBox";
            this.selectVoiceComboBox.Size = new System.Drawing.Size(266, 27);
            this.selectVoiceComboBox.TabIndex = 2;
            this.selectVoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.selectVoiceComboBox_SelectedIndexChanged);
            // 
            // showInstalledVoicesLabel
            // 
            this.showInstalledVoicesLabel.AutoSize = true;
            this.showInstalledVoicesLabel.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showInstalledVoicesLabel.Location = new System.Drawing.Point(13, 104);
            this.showInstalledVoicesLabel.Name = "showInstalledVoicesLabel";
            this.showInstalledVoicesLabel.Size = new System.Drawing.Size(150, 19);
            this.showInstalledVoicesLabel.TabIndex = 0;
            this.showInstalledVoicesLabel.Text = "Show installed voices: ";
            // 
            // showInstalledVoicesButton
            // 
            this.showInstalledVoicesButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showInstalledVoicesButton.Location = new System.Drawing.Point(169, 104);
            this.showInstalledVoicesButton.Name = "showInstalledVoicesButton";
            this.showInstalledVoicesButton.Size = new System.Drawing.Size(37, 28);
            this.showInstalledVoicesButton.TabIndex = 5;
            this.showInstalledVoicesButton.Text = "...";
            this.showInstalledVoicesButton.UseVisualStyleBackColor = true;
            this.showInstalledVoicesButton.Click += new System.EventHandler(this.showInstalledVoicesButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1234, 24);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveasToolStripMenuItem.Text = "Save as";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveasToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTextToolStripMenuItem,
            this.runToolStripMenuItem,
            this.runSelectedToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearTextToolStripMenuItem.Text = "Clear text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Tag = "run all";
            this.runToolStripMenuItem.Text = "Run all";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // runSelectedToolStripMenuItem
            // 
            this.runSelectedToolStripMenuItem.Name = "runSelectedToolStripMenuItem";
            this.runSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.runSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runSelectedToolStripMenuItem.Tag = "run selected";
            this.runSelectedToolStripMenuItem.Text = "Run selected";
            this.runSelectedToolStripMenuItem.Click += new System.EventHandler(this.runSelectedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openButton.Location = new System.Drawing.Point(958, 104);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(56, 28);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(1020, 104);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(49, 28);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveAsButton.Location = new System.Drawing.Point(1075, 104);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 28);
            this.saveAsButton.TabIndex = 11;
            this.saveAsButton.Text = "Save as";
            this.saveAsButton.UseVisualStyleBackColor = true;
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAvailableToolStripStatusLabel,
            this.documentNameToolStripStatusLabel,
            this.processingToolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 552);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1234, 24);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // saveAvailableToolStripStatusLabel
            // 
            this.saveAvailableToolStripStatusLabel.Name = "saveAvailableToolStripStatusLabel";
            this.saveAvailableToolStripStatusLabel.Size = new System.Drawing.Size(116, 19);
            this.saveAvailableToolStripStatusLabel.Text = "Save unavailable";
            // 
            // documentNameToolStripStatusLabel
            // 
            this.documentNameToolStripStatusLabel.Name = "documentNameToolStripStatusLabel";
            this.documentNameToolStripStatusLabel.Size = new System.Drawing.Size(87, 19);
            this.documentNameToolStripStatusLabel.Text = "No file name";
            // 
            // processingToolStripProgressBar
            // 
            this.processingToolStripProgressBar.Enabled = false;
            this.processingToolStripProgressBar.Name = "processingToolStripProgressBar";
            this.processingToolStripProgressBar.Size = new System.Drawing.Size(100, 18);
            this.processingToolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // mruComboBox
            // 
            this.mruComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mruComboBox.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mruComboBox.FormattingEnabled = true;
            this.mruComboBox.Items.AddRange(new object[] {
            "Recently opened"});
            this.mruComboBox.Location = new System.Drawing.Point(212, 104);
            this.mruComboBox.Name = "mruComboBox";
            this.mruComboBox.Size = new System.Drawing.Size(569, 27);
            this.mruComboBox.TabIndex = 6;
            this.mruComboBox.SelectedIndexChanged += new System.EventHandler(this.mruComboBox_SelectedIndexChanged);
            // 
            // newFileButton
            // 
            this.newFileButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newFileButton.Location = new System.Drawing.Point(896, 104);
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(56, 28);
            this.newFileButton.TabIndex = 8;
            this.newFileButton.Text = "New";
            this.newFileButton.UseVisualStyleBackColor = true;
            this.newFileButton.Click += new System.EventHandler(this.newFileButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(1156, 104);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(56, 28);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // clearMRUBbutton
            // 
            this.clearMRUBbutton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearMRUBbutton.Location = new System.Drawing.Point(787, 104);
            this.clearMRUBbutton.Name = "clearMRUBbutton";
            this.clearMRUBbutton.Size = new System.Drawing.Size(92, 28);
            this.clearMRUBbutton.TabIndex = 7;
            this.clearMRUBbutton.Text = "Clear MRU";
            this.clearMRUBbutton.UseVisualStyleBackColor = true;
            this.clearMRUBbutton.Click += new System.EventHandler(this.clearMRUBbutton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 576);
            this.Controls.Add(this.clearMRUBbutton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newFileButton);
            this.Controls.Add(this.mruComboBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.showInstalledVoicesButton);
            this.Controls.Add(this.showInstalledVoicesLabel);
            this.Controls.Add(this.selectVoiceComboBox);
            this.Controls.Add(this.selectVoiceLabel);
            this.Controls.Add(this.outputFileSelectorButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.outputFilelabel);
            this.Controls.Add(this.outputDeviceComboBox);
            this.Controls.Add(this.outputDevicelabel);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 615);
            this.MinimumSize = new System.Drawing.Size(1250, 615);
            this.Name = "MainWindow";
            this.Text = "Speech synthesizer";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputText;
        private Label outputDevicelabel;
        private ComboBox outputDeviceComboBox;
        private Label outputFilelabel;
        private TextBox outputFileTextBox;
        private Button outputFileSelectorButton;
        private Label selectVoiceLabel;
        private ComboBox selectVoiceComboBox;
        private Label showInstalledVoicesLabel;
        private Button showInstalledVoicesButton;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveasToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem clearTextToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem runSelectedToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button openButton;
        private Button saveButton;
        private Button saveAsButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel saveAvailableToolStripStatusLabel;
        private ToolStripStatusLabel documentNameToolStripStatusLabel;
        private ToolStripProgressBar processingToolStripProgressBar;
        private ComboBox mruComboBox;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button newFileButton;
        private Button clearButton;
        private Button clearMRUBbutton;
    }
}