namespace SpeechSynthesis
{
    partial class StatusDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.creationProgressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creationProgressBar
            // 
            this.creationProgressBar.Location = new System.Drawing.Point(14, 51);
            this.creationProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creationProgressBar.Name = "creationProgressBar";
            this.creationProgressBar.Size = new System.Drawing.Size(341, 29);
            this.creationProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.creationProgressBar.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(231, 94);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Close this dialog";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(11, 16);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(124, 19);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Processing text . . .";
            // 
            // StatusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 132);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.creationProgressBar);
            this.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatusDialog";
            this.Text = "Process status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar creationProgressBar;
        private Button cancelButton;
        private Label mainLabel;
    }
}