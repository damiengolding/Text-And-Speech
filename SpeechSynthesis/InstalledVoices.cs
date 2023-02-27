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
    public partial class InstalledVoicesDialog : Form
    {
        public InstalledVoicesDialog()
        {
            InitializeComponent();
        }

        private void InstalledVoicesDialog_Load(object sender, EventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    installedVoicesText.Text += "Name: " + info.Name + "\r\n";
                    installedVoicesText.Text += "\tCulture: " + info.Culture + "\r\n";
                    installedVoicesText.Text += "\tAge: " + info.Age + "\r\n";
                    installedVoicesText.Text += "\tGender: " + info.Gender + "\r\n";
                    installedVoicesText.Text += "\tDescription: " + info.Description + "\r\n";
                    installedVoicesText.Text += "\tID: " + info.Id + "\r\n";
                    installedVoicesText.Text += "\tEnabled: " + voice.Enabled + "\r\n\r\n";
                }
            }

        }
    }
}
