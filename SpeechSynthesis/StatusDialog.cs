using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechSynthesis
{
    public partial class StatusDialog : Form
    {
        private SpeechSynthesizer synth;
        Thread speakThread;
        public StatusDialog(SpeechSynthesizer ss, Thread st)
        {
            synth = ss;
            speakThread = st;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will not terminate the voice\r\ncreation process. Continue anyway?", "Close dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
