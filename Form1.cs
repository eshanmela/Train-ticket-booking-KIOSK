using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using CCNET;
using System.IO.Ports;
using System.Threading;

namespace TRainTicket2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SpeechSynthesizer spreader = new SpeechSynthesizer();
        private void btnSinhala_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("Simhala");
            this.Hide();
            frmSelect frmSele = new frmSelect();
            frmSele.Show();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("English");
            this.Hide();
            frmEng frmeng = new frmEng();
            frmeng.Show();
        }

        private void btnTamil_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("Tamil");
            this.Hide();
            frmTamil frmTam = new frmTamil();
            frmTam.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("Railway Map");
            this.Hide();
            frmmap frmMap = new frmmap();
            frmMap.Show();
        }
    }
}
