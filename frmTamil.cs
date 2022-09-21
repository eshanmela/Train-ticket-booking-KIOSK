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
    public partial class frmTamil : Form
    {
        public frmTamil()
        {
            InitializeComponent();
        }

        SpeechSynthesizer spreader = new SpeechSynthesizer();

        string verFrom, verTo, TClass, TType;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmhom = new Form1();
            frmhom.Show();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            TType =
    !String.IsNullOrWhiteSpace(cmbType.Text) && cmbType.Text.Length >= 1
    ? cmbType.Text.Substring(0, 1)
    : cmbType.Text;

            if (TType == "1")
            {

                spreader.SpeakAsync("Intercity Train");

                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket price is 20 rupees");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket price is 30 rupees");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket price is 40 rupees");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket price is 50 rupees");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket price is 60 rupees");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket price is 70 rupees");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket price is 80 rupees");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync(" ticket price is 90 rupees");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync(" ticket price is 100 rupees");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket price is 110 rupees");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket price is 120 rupees");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket price is 130 rupees");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync(" ticket price is 140 rupees");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync(" ticket price is 150 rupees");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync(" ticket price is 160 rupees");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync(" ticket price is 170 rupees");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync(" ticket price is 180 rupees");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync(" ticket price is 190 rupees");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }


            }

            else if (TType == "2")
            {
                spreader.SpeakAsync("Express Train");

                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket price is 20 rupees");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket price is 30 rupees");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket price is 40 rupees");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket price is 50 rupees");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket price is 60 rupees");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket price is 70 rupees");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket price is 80 rupees");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync(" ticket price is 90 rupees");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync(" ticket price is 100 rupees");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket price is 110 rupees");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket price is 120 rupees");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket price is 130 rupees");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync(" ticket price is 140 rupees");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync(" ticket price is 150 rupees");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync(" ticket price is 160 rupees");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync(" ticket price is 170 rupees");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync(" ticket price is 180 rupees");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync(" ticket price is 190 rupees");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
            }
            else if (TType == "3")
            {
                spreader.SpeakAsync("Slow Train");

                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket price is 20 rupees");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket price is 30 rupees");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket price is 40 rupees");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket price is 50 rupees");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket price is 60 rupees");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket price is 70 rupees");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket price is 80 rupees");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync(" ticket price is 90 rupees");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync(" ticket price is 100 rupees");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket price is 110 rupees");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket price is 120 rupees");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket price is 130 rupees");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync(" ticket price is 140 rupees");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync(" ticket price is 150 rupees");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync(" ticket price is 160 rupees");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync(" ticket price is 170 rupees");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync(" ticket price is 180 rupees");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync(" ticket price is 190 rupees");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
            }
            else if (TType == "4")
            {
                spreader.SpeakAsync("Mail Train");

                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket price is 20 rupees");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket price is 30 rupees");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket price is 40 rupees");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket price is 50 rupees");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket price is 60 rupees");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket price is 70 rupees");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket price is 80 rupees");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync(" ticket price is 90 rupees");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync(" ticket price is 100 rupees");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket price is 110 rupees");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket price is 120 rupees");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket price is 130 rupees");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync(" ticket price is 140 rupees");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync(" ticket price is 150 rupees");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync(" ticket price is 160 rupees");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync(" ticket price is 170 rupees");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync(" ticket price is 180 rupees");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync(" ticket price is 190 rupees");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket price is 10 rupees");
                }
            }
            else
            {

            }
        }

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            verFrom =
   !String.IsNullOrWhiteSpace(cmbFrom.Text) && cmbFrom.Text.Length >= 2
   ? cmbFrom.Text.Substring(0, 2)
   : cmbFrom.Text;

            if (verFrom == "01")
            {

                spreader.SpeakAsync("From Abanpola");

            }
            else if (verFrom == "02")
            {

                spreader.SpeakAsync("From Ahangama");

            }
            else if (verFrom == "03")
            {

                spreader.SpeakAsync("From Akurala");

            }
            else if (verFrom == "04")
            {

                spreader.SpeakAsync("From Alawwa");

            }
            else if (verFrom == "05")
            {

                spreader.SpeakAsync("From Alawathupitiya");

            }
            else if (verFrom == "06")
            {

                spreader.SpeakAsync("From Aluthgama");

            }
            else if (verFrom == "07")
            {

                spreader.SpeakAsync("From Ambalangoda");

            }
            else if (verFrom == "08")
            {

                spreader.SpeakAsync("From Ambepussa");

            }
            else if (verFrom == "09")
            {

                spreader.SpeakAsync("From Ambewela");

            }
            else if (verFrom == "10")
            {

                spreader.SpeakAsync("From Anavilundawa");

            }
            else if (verFrom == "11")
            {

                spreader.SpeakAsync("From Angulana");

            }
            else if (verFrom == "12")
            {

                spreader.SpeakAsync("From Anuradapura City");

            }
            else if (verFrom == "13")
            {

                spreader.SpeakAsync("From Anuradapura");

            }
            else if (verFrom == "14")
            {

                spreader.SpeakAsync("From Arachchikatuwa");

            }
            else if (verFrom == "15")
            {

                spreader.SpeakAsync("From Ahungalla");

            }
            else if (verFrom == "16")
            {

                spreader.SpeakAsync("From Awissawella");

            }
            else if (verFrom == "17")
            {

                spreader.SpeakAsync("From Awkana");

            }
            else if (verFrom == "18")
            {

                spreader.SpeakAsync("From Badulla");

            }
            else if (verFrom == "19")
            {

                spreader.SpeakAsync("From Balana");

            }
            else if (verFrom == "20")
            {

                spreader.SpeakAsync("From Balapitiya");

            }

            else
            {

                //pictureBox3.Image = null;
            }
        }

        private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            verTo =
    !String.IsNullOrWhiteSpace(cmbTo.Text) && cmbTo.Text.Length >= 2
    ? cmbTo.Text.Substring(0, 2)
    : cmbTo.Text;

            if (verTo == "01")
            {

                spreader.SpeakAsync("To Abanpola");

            }
            else if (verTo == "02")
            {

                spreader.SpeakAsync("To Ahangama");

            }
            else if (verTo == "03")
            {

                spreader.SpeakAsync("To Akurala");

            }
            else if (verTo == "04")
            {

                spreader.SpeakAsync("To Alawwa");

            }
            else if (verTo == "05")
            {

                spreader.SpeakAsync("To Alawathupitiya");

            }
            else if (verTo == "06")
            {

                spreader.SpeakAsync("To Aluthgama");

            }
            else if (verTo == "07")
            {

                spreader.SpeakAsync("To Ambalangoda");

            }
            else if (verTo == "08")
            {

                spreader.SpeakAsync("To Ambepussa");

            }
            else if (verTo == "09")
            {

                spreader.SpeakAsync("To Ambewela");

            }
            else if (verTo == "10")
            {

                spreader.SpeakAsync("To Anavilundawa");

            }
            else if (verTo == "11")
            {

                spreader.SpeakAsync("To Angulana");

            }
            else if (verTo == "12")
            {

                spreader.SpeakAsync("To Anuradapura City");

            }
            else if (verTo == "13")
            {

                spreader.SpeakAsync("To Anuradapura");

            }
            else if (verTo == "14")
            {

                spreader.SpeakAsync("To Arachchikatuwa");

            }
            else if (verTo == "15")
            {

                spreader.SpeakAsync("To Ahungalla");

            }
            else if (verTo == "16")
            {

                spreader.SpeakAsync("To Awissawella");

            }
            else if (verTo == "17")
            {

                spreader.SpeakAsync("To Awkana");

            }
            else if (verTo == "18")
            {

                spreader.SpeakAsync("To Badulla");

            }
            else if (verTo == "19")
            {

                spreader.SpeakAsync("To Balana");

            }
            else if (verTo == "20")
            {

                spreader.SpeakAsync("To Balapitiya");

            }

            else
            {

                //pictureBox3.Image = null;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            TClass =
    !String.IsNullOrWhiteSpace(cmbClass.Text) && cmbClass.Text.Length >= 1
    ? cmbClass.Text.Substring(0, 1)
    : cmbClass.Text;

            if (TClass == "1")
            {

                spreader.SpeakAsync("1st Class");

            }
            else if (TClass == "2")
            {
                spreader.SpeakAsync("2nd Class");
            }
            else if (TClass == "3")
            {
                spreader.SpeakAsync("3rd Class");
            }
            else
            {

            }
        }
    }
}
