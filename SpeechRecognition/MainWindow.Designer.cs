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


using System.Speech.Recognition;

namespace SpeechRecognition
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
            this.outputText = new System.Windows.Forms.TextBox();
            this.grammarsLabel = new System.Windows.Forms.Label();
            this.grammarsComboBox = new System.Windows.Forms.ComboBox();
            this.babbleTimeout = new System.Windows.Forms.NumericUpDown();
            this.labelbabbleTimeoutL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.initialSilenceTimeout = new System.Windows.Forms.NumericUpDown();
            this.activateButton = new System.Windows.Forms.Button();
            this.deactivateButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.saveTextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveTextAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearOutputToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zeroBabbleLabel = new System.Windows.Forms.Label();
            this.zeroInitialTimeoutLabel = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.saveAvailableToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.documentNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.processingToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.babbleTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialSilenceTimeout)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputText.Location = new System.Drawing.Point(12, 115);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputText.Size = new System.Drawing.Size(1210, 484);
            this.outputText.TabIndex = 6;
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // grammarsLabel
            // 
            this.grammarsLabel.AutoSize = true;
            this.grammarsLabel.Location = new System.Drawing.Point(17, 29);
            this.grammarsLabel.Name = "grammarsLabel";
            this.grammarsLabel.Size = new System.Drawing.Size(138, 19);
            this.grammarsLabel.TabIndex = 0;
            this.grammarsLabel.Text = "Available grammars:";
            this.grammarsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grammarsComboBox
            // 
            this.grammarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grammarsComboBox.FormattingEnabled = true;
            this.grammarsComboBox.Location = new System.Drawing.Point(161, 29);
            this.grammarsComboBox.Name = "grammarsComboBox";
            this.grammarsComboBox.Size = new System.Drawing.Size(289, 27);
            this.grammarsComboBox.TabIndex = 1;
            // 
            // babbleTimeout
            // 
            this.babbleTimeout.Location = new System.Drawing.Point(161, 69);
            this.babbleTimeout.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.babbleTimeout.Name = "babbleTimeout";
            this.babbleTimeout.Size = new System.Drawing.Size(57, 26);
            this.babbleTimeout.TabIndex = 2;
            // 
            // labelbabbleTimeoutL
            // 
            this.labelbabbleTimeoutL.AutoSize = true;
            this.labelbabbleTimeoutL.Location = new System.Drawing.Point(17, 71);
            this.labelbabbleTimeoutL.Name = "labelbabbleTimeoutL";
            this.labelbabbleTimeoutL.Size = new System.Drawing.Size(109, 19);
            this.labelbabbleTimeoutL.TabIndex = 0;
            this.labelbabbleTimeoutL.Text = "Babble timeout:";
            this.labelbabbleTimeoutL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial silence timeout:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // initialSilenceTimeout
            // 
            this.initialSilenceTimeout.Location = new System.Drawing.Point(393, 69);
            this.initialSilenceTimeout.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.initialSilenceTimeout.Name = "initialSilenceTimeout";
            this.initialSilenceTimeout.Size = new System.Drawing.Size(57, 26);
            this.initialSilenceTimeout.TabIndex = 3;
            this.initialSilenceTimeout.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(481, 29);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(180, 27);
            this.activateButton.TabIndex = 4;
            this.activateButton.Text = "&Activate recognition";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // deactivateButton
            // 
            this.deactivateButton.Enabled = false;
            this.deactivateButton.Location = new System.Drawing.Point(481, 69);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(180, 27);
            this.deactivateButton.TabIndex = 5;
            this.deactivateButton.Text = "&Deactivate recognition";
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTextToolStripButton,
            this.saveTextAsToolStripButton,
            this.clearOutputToolStripButton,
            this.aboutToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1234, 26);
            this.toolStrip.TabIndex = 19;
            this.toolStrip.Text = "toolStrip1";
            // 
            // saveTextToolStripButton
            // 
            this.saveTextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveTextToolStripButton.Enabled = false;
            this.saveTextToolStripButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveTextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTextToolStripButton.Image")));
            this.saveTextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTextToolStripButton.Name = "saveTextToolStripButton";
            this.saveTextToolStripButton.Size = new System.Drawing.Size(70, 23);
            this.saveTextToolStripButton.Text = "Save text";
            this.saveTextToolStripButton.Click += new System.EventHandler(this.saveTextToolStripButton_Click);
            // 
            // saveTextAsToolStripButton
            // 
            this.saveTextAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveTextAsToolStripButton.Enabled = false;
            this.saveTextAsToolStripButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveTextAsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveTextAsToolStripButton.Image")));
            this.saveTextAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTextAsToolStripButton.Name = "saveTextAsToolStripButton";
            this.saveTextAsToolStripButton.Size = new System.Drawing.Size(87, 23);
            this.saveTextAsToolStripButton.Text = "Save text as";
            this.saveTextAsToolStripButton.Click += new System.EventHandler(this.saveTextAsToolStripButton_Click);
            // 
            // clearOutputToolStripButton
            // 
            this.clearOutputToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearOutputToolStripButton.Enabled = false;
            this.clearOutputToolStripButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearOutputToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearOutputToolStripButton.Image")));
            this.clearOutputToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearOutputToolStripButton.Name = "clearOutputToolStripButton";
            this.clearOutputToolStripButton.Size = new System.Drawing.Size(144, 23);
            this.clearOutputToolStripButton.Text = "Clear output window";
            this.clearOutputToolStripButton.Click += new System.EventHandler(this.clearOutputToolStripButton_Click);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripButton.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(50, 23);
            this.aboutToolStripButton.Text = "About";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // zeroBabbleLabel
            // 
            this.zeroBabbleLabel.AutoSize = true;
            this.zeroBabbleLabel.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.zeroBabbleLabel.Location = new System.Drawing.Point(17, 95);
            this.zeroBabbleLabel.Name = "zeroBabbleLabel";
            this.zeroBabbleLabel.Size = new System.Drawing.Size(117, 17);
            this.zeroBabbleLabel.TabIndex = 0;
            this.zeroBabbleLabel.Text = "(zero for no timeout)";
            this.zeroBabbleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeroInitialTimeoutLabel
            // 
            this.zeroInitialTimeoutLabel.AutoSize = true;
            this.zeroInitialTimeoutLabel.Font = new System.Drawing.Font("Source Sans Pro", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.zeroInitialTimeoutLabel.Location = new System.Drawing.Point(239, 95);
            this.zeroInitialTimeoutLabel.Name = "zeroInitialTimeoutLabel";
            this.zeroInitialTimeoutLabel.Size = new System.Drawing.Size(117, 17);
            this.zeroInitialTimeoutLabel.TabIndex = 0;
            this.zeroInitialTimeoutLabel.Text = "(zero for no timeout)";
            this.zeroInitialTimeoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAvailableToolStripStatusLabel,
            this.documentNameToolStripStatusLabel,
            this.processingToolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 587);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1234, 24);
            this.statusStrip.TabIndex = 20;
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
            this.processingToolStripProgressBar.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 611);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.zeroInitialTimeoutLabel);
            this.Controls.Add(this.zeroBabbleLabel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.deactivateButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.initialSilenceTimeout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelbabbleTimeoutL);
            this.Controls.Add(this.babbleTimeout);
            this.Controls.Add(this.grammarsComboBox);
            this.Controls.Add(this.grammarsLabel);
            this.Controls.Add(this.outputText);
            this.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1250, 650);
            this.MinimumSize = new System.Drawing.Size(1250, 650);
            this.Name = "MainWindow";
            this.Text = "Speech recognition - idle";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.babbleTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialSilenceTimeout)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox outputText;
        private Label grammarsLabel;
        private ComboBox grammarsComboBox;
        private NumericUpDown babbleTimeout;
        private Label labelbabbleTimeoutL;
        private Label label1;
        private NumericUpDown initialSilenceTimeout;
        private Button activateButton;
        private Button deactivateButton;
        private ToolStrip toolStrip;
        private ToolStripButton saveTextToolStripButton;
        private ToolStripButton saveTextAsToolStripButton;
        private ToolStripButton clearOutputToolStripButton;
        private Label zeroBabbleLabel;
        private Label zeroInitialTimeoutLabel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel saveAvailableToolStripStatusLabel;
        private ToolStripProgressBar processingToolStripProgressBar;
        private ToolStripStatusLabel documentNameToolStripStatusLabel;
        private ToolStripButton aboutToolStripButton;
    }
}