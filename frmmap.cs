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



namespace TRainTicket2
{
    public partial class frmmap : Form
    {
        public frmmap()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void frmmap_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.google.com/maps/d/embed?mid=1MWgzBW7Lpk_TT8gNhq1qCmYzeBg&hl=en_US");
        }
        SpeechSynthesizer spreader = new SpeechSynthesizer();
        private void btnBack_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("Back");
            this.Hide();
            Form1 frmhom = new Form1();
            frmhom.Show();
        }
    }
}
