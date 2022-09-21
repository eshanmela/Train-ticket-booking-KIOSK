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
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
            
        }

        SpeechSynthesizer spreader = new SpeechSynthesizer();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmhom = new Form1();
            frmhom.Show();
        }

        string verFrom, verTo, TClass, TType;

        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            verFrom =
    !String.IsNullOrWhiteSpace(cmbFrom.Text) && cmbFrom.Text.Length >= 2
    ? cmbFrom.Text.Substring(0, 2)
    : cmbFrom.Text;
            Global.LFrom = cmbFrom.Text.ToString();
            if (verFrom == "01")
            {

                spreader.SpeakAsync("Abanpola seeta");
                
                
            }
            else if (verFrom == "02")
            {

                spreader.SpeakAsync("Ahangama seeta");
               
            }
            else if (verFrom == "03")
            {

                spreader.SpeakAsync("Akurala seeta");
                
            }
            else if (verFrom == "04")
            {

                spreader.SpeakAsync("Alawwa seeta");
               
            }
            else if (verFrom == "05")
            {

                spreader.SpeakAsync("Alawathupitiya seeta");
                
            }
            else if (verFrom == "06")
            {

                spreader.SpeakAsync("Aluthgama seeta");
                
            }
            else if (verFrom == "07")
            {

                spreader.SpeakAsync("Ambalangoda seeta");
               
            }
            else if (verFrom == "08")
            {

                spreader.SpeakAsync("Ambepussa seeta");
                
            }
            else if (verFrom == "09")
            {

                spreader.SpeakAsync("Ambewela seeta");
               
            }
            else if (verFrom == "10")
            {

                spreader.SpeakAsync("Anavilundawa seeta");
               
            }
            else if (verFrom == "11")
            {

                spreader.SpeakAsync("Angulana seeta");
                
            }
            else if (verFrom == "12")
            {

                spreader.SpeakAsync("Anuradapura nagaraya seeta");
               
            }
            else if (verFrom == "13")
            {

                spreader.SpeakAsync("Anuradapura seeta");
                
            }
            else if (verFrom == "14")
            {

                spreader.SpeakAsync("Arachchikatuwa seeta");
                
            }
            else if (verFrom == "15")
            {

                spreader.SpeakAsync("Ahungalla seeta");
                
            }
            else if (verFrom == "16")
            {

                spreader.SpeakAsync("Awissawella seeta");
               
            }
            else if (verFrom == "17")
            {

                spreader.SpeakAsync("Awkana seeta");
               
            }
            else if (verFrom == "18")
            {

                spreader.SpeakAsync("Badulla seeta");
                
            }
            else if (verFrom == "19")
            {

                spreader.SpeakAsync("Balana seeta");
                
            }
            else if (verFrom == "20")
            {

                spreader.SpeakAsync("Balapitiya seeta");
               
            }

            else
            {

                //pictureBox3.Image = null;
            }
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {

        }

        private void cmbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            verTo =
    !String.IsNullOrWhiteSpace(cmbTo.Text) && cmbTo.Text.Length >= 2
    ? cmbTo.Text.Substring(0, 2)
    : cmbTo.Text;
            Global.LTo = cmbTo.Text.ToString();
            if (verTo == "01")
            {

                spreader.SpeakAsync("Abanpola dakwar");

            }
            else if (verTo == "02")
            {

                spreader.SpeakAsync("Ahangama dakwar");

            }
            else if (verTo == "03")
            {

                spreader.SpeakAsync("Akurala dakwar");

            }
            else if (verTo == "04")
            {

                spreader.SpeakAsync("Alawwa dakwar");

            }
            else if (verTo == "05")
            {

                spreader.SpeakAsync("Alawathupitiya dakwar");

            }
            else if (verTo == "06")
            {

                spreader.SpeakAsync("Aluthgama dakwar");

            }
            else if (verTo == "07")
            {

                spreader.SpeakAsync("Ambalangoda dakwar");

            }
            else if (verTo == "08")
            {

                spreader.SpeakAsync("Ambepussa dakwar");

            }
            else if (verTo == "09")
            {

                spreader.SpeakAsync("Ambewela dakwar");

            }
            else if (verTo == "10")
            {

                spreader.SpeakAsync("Anavilundawa dakwar");

            }
            else if (verTo == "11")
            {

                spreader.SpeakAsync("Angulana dakwar");

            }
            else if (verTo == "12")
            {

                spreader.SpeakAsync("Anuradapura nagaraya dakwar");

            }
            else if (verTo == "13")
            {

                spreader.SpeakAsync("Anuradapura dakwar");

            }
            else if (verTo == "14")
            {

                spreader.SpeakAsync("Arachchikatuwa dakwar");

            }
            else if (verTo == "15")
            {

                spreader.SpeakAsync("Ahungalla dakwar");

            }
            else if (verTo == "16")
            {

                spreader.SpeakAsync("Awissawella dakwar");

            }
            else if (verTo == "17")
            {

                spreader.SpeakAsync("Awkana dakwar");

            }
            else if (verTo == "18")
            {

                spreader.SpeakAsync("Badulla dakwar");

            }
            else if (verTo == "19")
            {

                spreader.SpeakAsync("Balana dakwar");

            }
            else if (verTo == "20")
            {

                spreader.SpeakAsync("Balapitiya dakwar");

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
            Global.LClass = cmbClass.Text.ToString();
            if (TClass == "1")
            {

                spreader.SpeakAsync("palaweni pantiya");
                
            }
            else if (TClass == "2")
            {
                spreader.SpeakAsync("deweni pantiya");
            }
            else if (TClass == "3")
            {
                spreader.SpeakAsync("tunweni pantiya");
            }
            else 
            {
               
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TType =
    !String.IsNullOrWhiteSpace(cmbType.Text) && cmbType.Text.Length >= 1
    ? cmbType.Text.Substring(0, 1)
    : cmbType.Text;
            Global.LType = cmbType.Text.ToString();
            if (TType == "1")
            {

                spreader.SpeakAsync("nagaranthara");

                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal dhahayayi ");
                    
                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal vissayi");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal thihayi");
                }
                
                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20") 
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal panahayi");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hetayi");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal heththeawayi");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal asuwayi");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal anuwayi");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal siyayi");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya dhahayayi");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20") 
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya vissayi");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07") )
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya thihayi");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20") 
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06") )
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05") )
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya panahayi");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20") 
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04") )
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hetayi");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20") 
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya heththewayi");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20") 
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02") )
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya asuwayi");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya anuwayi");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal dhahayayi"); 
                }


            }

            else if (TType == "2")
            {
                spreader.SpeakAsync("Thapal");
                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal dhahayayi ");

                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal vissayi");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal thihayi");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal panahayi");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hetayi");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal heththeawayi");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal asuwayi");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal anuwayi");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal siyayi");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya dhahayayi");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya vissayi");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya thihayi");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya panahayi");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hetayi");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya heththewayi");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya asuwayi");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya anuwayi");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal dhahayayi");
                }
            }
            else if (TType == "4")
            {
                spreader.SpeakAsync("seegragarmi");
                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal dhahayayi ");

                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal vissayi");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal thihayi");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal panahayi");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hetayi");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal heththeawayi");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal asuwayi");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal anuwayi");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal siyayi");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya dhahayayi");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya vissayi");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya thihayi");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya panahayi");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hetayi");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya heththewayi");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya asuwayi");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya anuwayi");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal dhahayayi");
                }
            }
            else if (TType == "3")
            {
                spreader.SpeakAsync("mamdagarmi");
                if ((verFrom == "01" && verTo == "02") || (verFrom == "02" && verTo == "03") || (verFrom == "03" && verTo == "04") || (verFrom == "04" && verTo == "05") || (verFrom == "05" && verTo == "06") || (verFrom == "06" && verTo == "07") || (verFrom == "07" && verTo == "08") || (verFrom == "08" && verTo == "09") || (verFrom == "09" && verTo == "10") || (verFrom == "10" && verTo == "11") || (verFrom == "11" && verTo == "12") || (verFrom == "12" && verTo == "13") || (verFrom == "13" && verTo == "14") || (verFrom == "14" && verTo == "15") || (verFrom == "15" && verTo == "16") || (verFrom == "16" && verTo == "17") || (verFrom == "17" && verTo == "18") || (verFrom == "18" && verTo == "19") || (verFrom == "19" && verTo == "20")
                    || (verFrom == "02" && verTo == "01") || (verFrom == "03" && verTo == "02") || (verFrom == "04" && verTo == "03") || (verFrom == "05" && verTo == "04") || (verFrom == "06" && verTo == "05") || (verFrom == "07" && verTo == "06") || (verFrom == "08" && verTo == "07") || (verFrom == "09" && verTo == "08") || (verFrom == "10" && verTo == "09") || (verFrom == "11" && verTo == "10") || (verFrom == "12" && verTo == "11") || (verFrom == "13" && verTo == "12") || (verFrom == "14" && verTo == "13") || (verFrom == "15" && verTo == "14") || (verFrom == "16" && verTo == "15") || (verFrom == "17" && verTo == "16") || (verFrom == "18" && verTo == "17") || (verFrom == "19" && verTo == "18") || (verFrom == "20" && verTo == "19"))
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal dhahayayi ");

                }
                else if ((verFrom == "01" && verTo == "03") || (verFrom == "02" && verTo == "04") || (verFrom == "03" && verTo == "05") || (verFrom == "04" && verTo == "06") || (verFrom == "05" && verTo == "07") || (verFrom == "06" && verTo == "08") || (verFrom == "07" && verTo == "09") || (verFrom == "08" && verTo == "10") || (verFrom == "09" && verTo == "11") || (verFrom == "10" && verTo == "12") || (verFrom == "11" && verTo == "13") || (verFrom == "12" && verTo == "14") || (verFrom == "13" && verTo == "15") || (verFrom == "14" && verTo == "16") || (verFrom == "15" && verTo == "17") || (verFrom == "16" && verTo == "18") || (verFrom == "17" && verTo == "19") || (verFrom == "18" && verTo == "20")
                   || (verFrom == "03" && verTo == "01") || (verFrom == "04" && verTo == "02") || (verFrom == "05" && verTo == "03") || (verFrom == "06" && verTo == "04") || (verFrom == "07" && verTo == "05") || (verFrom == "08" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "10" && verTo == "08") || (verFrom == "11" && verTo == "09") || (verFrom == "12" && verTo == "10") || (verFrom == "13" && verTo == "11") || (verFrom == "14" && verTo == "12") || (verFrom == "15" && verTo == "13") || (verFrom == "16" && verTo == "14") || (verFrom == "17" && verTo == "15") || (verFrom == "18" && verTo == "16") || (verFrom == "19" && verTo == "17") || (verFrom == "20" && verTo == "18"))
                {
                    lblPrice.Text = "20.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal vissayi");
                }
                else if ((verFrom == "01" && verTo == "04") || (verFrom == "02" && verTo == "05") || (verFrom == "03" && verTo == "06") || (verFrom == "04" && verTo == "07") || (verFrom == "05" && verTo == "08") || (verFrom == "06" && verTo == "09") || (verFrom == "07" && verTo == "10") || (verFrom == "08" && verTo == "11") || (verFrom == "09" && verTo == "12") || (verFrom == "10" && verTo == "13") || (verFrom == "11" && verTo == "14") || (verFrom == "12" && verTo == "15") || (verFrom == "13" && verTo == "16") || (verFrom == "14" && verTo == "17") || (verFrom == "15" && verTo == "18") || (verFrom == "16" && verTo == "19") || (verFrom == "17" && verTo == "20")
                   || (verFrom == "04" && verTo == "01") || (verFrom == "05" && verTo == "02") || (verFrom == "06" && verTo == "03") || (verFrom == "07" && verTo == "04") || (verFrom == "08" && verTo == "05") || (verFrom == "09" && verTo == "06") || (verFrom == "09" && verTo == "07") || (verFrom == "11" && verTo == "08") || (verFrom == "12" && verTo == "09") || (verFrom == "13" && verTo == "10") || (verFrom == "14" && verTo == "11") || (verFrom == "15" && verTo == "12") || (verFrom == "16" && verTo == "13") || (verFrom == "17" && verTo == "14") || (verFrom == "18" && verTo == "15") || (verFrom == "19" && verTo == "16") || (verFrom == "20" && verTo == "17"))
                {
                    lblPrice.Text = "30.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal thihayi");
                }

                else if ((verFrom == "01" && verTo == "05") || (verFrom == "02" && verTo == "06") || (verFrom == "03" && verTo == "07") || (verFrom == "04" && verTo == "08") || (verFrom == "05" && verTo == "09") || (verFrom == "06" && verTo == "10") || (verFrom == "07" && verTo == "11") || (verFrom == "08" && verTo == "12") || (verFrom == "09" && verTo == "13") || (verFrom == "10" && verTo == "14") || (verFrom == "11" && verTo == "15") || (verFrom == "12" && verTo == "16") || (verFrom == "13" && verTo == "17") || (verFrom == "14" && verTo == "18") || (verFrom == "15" && verTo == "19") || (verFrom == "16" && verTo == "20")
                   || (verFrom == "05" && verTo == "01") || (verFrom == "06" && verTo == "02") || (verFrom == "07" && verTo == "03") || (verFrom == "08" && verTo == "04") || (verFrom == "09" && verTo == "05") || (verFrom == "10" && verTo == "06") || (verFrom == "11" && verTo == "07") || (verFrom == "12" && verTo == "08") || (verFrom == "13" && verTo == "09") || (verFrom == "14" && verTo == "10") || (verFrom == "15" && verTo == "11") || (verFrom == "16" && verTo == "12") || (verFrom == "17" && verTo == "13") || (verFrom == "18" && verTo == "14") || (verFrom == "19" && verTo == "15") || (verFrom == "20" && verTo == "16"))
                {
                    lblPrice.Text = "40.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "06") || (verFrom == "02" && verTo == "07") || (verFrom == "03" && verTo == "08") || (verFrom == "04" && verTo == "09") || (verFrom == "05" && verTo == "10") || (verFrom == "06" && verTo == "11") || (verFrom == "07" && verTo == "12") || (verFrom == "08" && verTo == "13") || (verFrom == "09" && verTo == "14") || (verFrom == "10" && verTo == "15") || (verFrom == "11" && verTo == "16") || (verFrom == "12" && verTo == "17") || (verFrom == "13" && verTo == "18") || (verFrom == "14" && verTo == "19") || (verFrom == "15" && verTo == "20")
                   || (verFrom == "06" && verTo == "01") || (verFrom == "07" && verTo == "02") || (verFrom == "08" && verTo == "03") || (verFrom == "09" && verTo == "04") || (verFrom == "10" && verTo == "05") || (verFrom == "11" && verTo == "06") || (verFrom == "12" && verTo == "07") || (verFrom == "13" && verTo == "08") || (verFrom == "14" && verTo == "09") || (verFrom == "15" && verTo == "10") || (verFrom == "16" && verTo == "11") || (verFrom == "17" && verTo == "12") || (verFrom == "18" && verTo == "13") || (verFrom == "19" && verTo == "14") || (verFrom == "20" && verTo == "15"))
                {
                    lblPrice.Text = "50.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal panahayi");
                }
                else if ((verFrom == "01" && verTo == "07") || (verFrom == "02" && verTo == "08") || (verFrom == "03" && verTo == "09") || (verFrom == "04" && verTo == "10") || (verFrom == "05" && verTo == "11") || (verFrom == "06" && verTo == "12") || (verFrom == "07" && verTo == "13") || (verFrom == "08" && verTo == "14") || (verFrom == "09" && verTo == "15") || (verFrom == "10" && verTo == "16") || (verFrom == "11" && verTo == "17") || (verFrom == "12" && verTo == "18") || (verFrom == "13" && verTo == "19") || (verFrom == "14" && verTo == "20")
                   || (verFrom == "07" && verTo == "01") || (verFrom == "08" && verTo == "02") || (verFrom == "09" && verTo == "03") || (verFrom == "10" && verTo == "04") || (verFrom == "11" && verTo == "05") || (verFrom == "12" && verTo == "06") || (verFrom == "13" && verTo == "07") || (verFrom == "14" && verTo == "08") || (verFrom == "15" && verTo == "09") || (verFrom == "16" && verTo == "10") || (verFrom == "17" && verTo == "11") || (verFrom == "18" && verTo == "12") || (verFrom == "19" && verTo == "13") || (verFrom == "20" && verTo == "14"))
                {
                    lblPrice.Text = "60.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal hetayi");
                }
                else if ((verFrom == "01" && verTo == "08") || (verFrom == "02" && verTo == "09") || (verFrom == "03" && verTo == "10") || (verFrom == "04" && verTo == "11") || (verFrom == "05" && verTo == "12") || (verFrom == "06" && verTo == "13") || (verFrom == "07" && verTo == "14") || (verFrom == "08" && verTo == "15") || (verFrom == "09" && verTo == "16") || (verFrom == "10" && verTo == "17") || (verFrom == "11" && verTo == "18") || (verFrom == "12" && verTo == "19") || (verFrom == "13" && verTo == "20")
                   || (verFrom == "08" && verTo == "01") || (verFrom == "09" && verTo == "02") || (verFrom == "10" && verTo == "03") || (verFrom == "11" && verTo == "04") || (verFrom == "12" && verTo == "05") || (verFrom == "13" && verTo == "06") || (verFrom == "14" && verTo == "07") || (verFrom == "15" && verTo == "08") || (verFrom == "16" && verTo == "09") || (verFrom == "17" && verTo == "10") || (verFrom == "18" && verTo == "11") || (verFrom == "19" && verTo == "12") || (verFrom == "20" && verTo == "13"))
                {
                    lblPrice.Text = "70.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal heththeawayi");
                }
                else if ((verFrom == "01" && verTo == "09") || (verFrom == "02" && verTo == "10") || (verFrom == "03" && verTo == "11") || (verFrom == "04" && verTo == "12") || (verFrom == "05" && verTo == "13") || (verFrom == "06" && verTo == "14") || (verFrom == "07" && verTo == "15") || (verFrom == "08" && verTo == "16") || (verFrom == "09" && verTo == "17") || (verFrom == "10" && verTo == "18") || (verFrom == "11" && verTo == "19") || (verFrom == "12" && verTo == "20")
                   || (verFrom == "09" && verTo == "01") || (verFrom == "10" && verTo == "02") || (verFrom == "11" && verTo == "03") || (verFrom == "12" && verTo == "04") || (verFrom == "13" && verTo == "05") || (verFrom == "14" && verTo == "06") || (verFrom == "15" && verTo == "07") || (verFrom == "16" && verTo == "08") || (verFrom == "17" && verTo == "09") || (verFrom == "18" && verTo == "10") || (verFrom == "19" && verTo == "11") || (verFrom == "20" && verTo == "12"))
                {
                    lblPrice.Text = "80.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal asuwayi");
                }
                else if ((verFrom == "01" && verTo == "10") || (verFrom == "02" && verTo == "11") || (verFrom == "03" && verTo == "12") || (verFrom == "04" && verTo == "13") || (verFrom == "05" && verTo == "14") || (verFrom == "06" && verTo == "15") || (verFrom == "07" && verTo == "16") || (verFrom == "08" && verTo == "17") || (verFrom == "09" && verTo == "18") || (verFrom == "10" && verTo == "19") || (verFrom == "11" && verTo == "20")
                   || (verFrom == "10" && verTo == "01") || (verFrom == "11" && verTo == "02") || (verFrom == "12" && verTo == "03") || (verFrom == "13" && verTo == "04") || (verFrom == "14" && verTo == "05") || (verFrom == "15" && verTo == "06") || (verFrom == "16" && verTo == "07") || (verFrom == "17" && verTo == "08") || (verFrom == "18" && verTo == "09") || (verFrom == "19" && verTo == "10") || (verFrom == "20" && verTo == "11"))
                {
                    lblPrice.Text = "90.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal anuwayi");
                }
                else if ((verFrom == "01" && verTo == "11") || (verFrom == "02" && verTo == "12") || (verFrom == "03" && verTo == "13") || (verFrom == "04" && verTo == "14") || (verFrom == "05" && verTo == "15") || (verFrom == "06" && verTo == "16") || (verFrom == "07" && verTo == "17") || (verFrom == "08" && verTo == "18") || (verFrom == "09" && verTo == "19") || (verFrom == "10" && verTo == "20")
                   || (verFrom == "11" && verTo == "01") || (verFrom == "12" && verTo == "02") || (verFrom == "13" && verTo == "03") || (verFrom == "14" && verTo == "04") || (verFrom == "15" && verTo == "05") || (verFrom == "16" && verTo == "06") || (verFrom == "17" && verTo == "07") || (verFrom == "18" && verTo == "08") || (verFrom == "19" && verTo == "09") || (verFrom == "20" && verTo == "10"))
                {
                    lblPrice.Text = "100.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal siyayi");
                }
                else if ((verFrom == "01" && verTo == "12") || (verFrom == "02" && verTo == "13") || (verFrom == "03" && verTo == "14") || (verFrom == "04" && verTo == "15") || (verFrom == "05" && verTo == "16") || (verFrom == "06" && verTo == "17") || (verFrom == "07" && verTo == "18") || (verFrom == "08" && verTo == "19") || (verFrom == "09" && verTo == "20")
                   || (verFrom == "12" && verTo == "01") || (verFrom == "13" && verTo == "02") || (verFrom == "14" && verTo == "03") || (verFrom == "15" && verTo == "04") || (verFrom == "16" && verTo == "05") || (verFrom == "17" && verTo == "06") || (verFrom == "18" && verTo == "07") || (verFrom == "19" && verTo == "08") || (verFrom == "20" && verTo == "09"))
                {
                    lblPrice.Text = "110.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya dhahayayi");
                }

                else if ((verFrom == "01" && verTo == "13") || (verFrom == "02" && verTo == "14") || (verFrom == "03" && verTo == "15") || (verFrom == "04" && verTo == "16") || (verFrom == "05" && verTo == "17") || (verFrom == "06" && verTo == "18") || (verFrom == "07" && verTo == "19") || (verFrom == "08" && verTo == "20")
                   || (verFrom == "13" && verTo == "01") || (verFrom == "14" && verTo == "02") || (verFrom == "15" && verTo == "03") || (verFrom == "16" && verTo == "04") || (verFrom == "17" && verTo == "05") || (verFrom == "18" && verTo == "06") || (verFrom == "19" && verTo == "07") || (verFrom == "20" && verTo == "08"))
                {
                    lblPrice.Text = "120.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya vissayi");
                }
                else if ((verFrom == "01" && verTo == "14") || (verFrom == "02" && verTo == "15") || (verFrom == "03" && verTo == "16") || (verFrom == "04" && verTo == "17") || (verFrom == "05" && verTo == "18") || (verFrom == "06" && verTo == "19") || (verFrom == "07" && verTo == "20")
                   || (verFrom == "14" && verTo == "01") || (verFrom == "15" && verTo == "02") || (verFrom == "16" && verTo == "03") || (verFrom == "17" && verTo == "04") || (verFrom == "18" && verTo == "05") || (verFrom == "19" && verTo == "06") || (verFrom == "20" && verTo == "07"))
                {
                    lblPrice.Text = "130.00";
                    spreader.SpeakAsync(" ticket pathea mila rupiyal ekasiya thihayi");
                }
                else if ((verFrom == "01" && verTo == "15") || (verFrom == "02" && verTo == "16") || (verFrom == "03" && verTo == "17") || (verFrom == "04" && verTo == "18") || (verFrom == "05" && verTo == "19") || (verFrom == "06" && verTo == "20")
                   || (verFrom == "15" && verTo == "01") || (verFrom == "16" && verTo == "02") || (verFrom == "17" && verTo == "03") || (verFrom == "18" && verTo == "04") || (verFrom == "19" && verTo == "05") || (verFrom == "20" && verTo == "06"))
                {
                    lblPrice.Text = "140.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hathalihayi");
                }
                else if ((verFrom == "01" && verTo == "16") || (verFrom == "02" && verTo == "17") || (verFrom == "03" && verTo == "18") || (verFrom == "04" && verTo == "19") || (verFrom == "05" && verTo == "20")
                   || (verFrom == "16" && verTo == "01") || (verFrom == "17" && verTo == "02") || (verFrom == "18" && verTo == "03") || (verFrom == "19" && verTo == "04") || (verFrom == "20" && verTo == "05"))
                {
                    lblPrice.Text = "150.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya panahayi");
                }
                else if ((verFrom == "01" && verTo == "17") || (verFrom == "02" && verTo == "18") || (verFrom == "03" && verTo == "19") || (verFrom == "04" && verTo == "20")
                   || (verFrom == "17" && verTo == "01") || (verFrom == "18" && verTo == "02") || (verFrom == "19" && verTo == "03") || (verFrom == "20" && verTo == "04"))
                {
                    lblPrice.Text = "160.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya hetayi");
                }
                else if ((verFrom == "01" && verTo == "18") || (verFrom == "02" && verTo == "19") || (verFrom == "03" && verTo == "20")
                   || (verFrom == "18" && verTo == "01") || (verFrom == "19" && verTo == "02") || (verFrom == "20" && verTo == "03"))
                {
                    lblPrice.Text = "170.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya heththewayi");
                }
                else if ((verFrom == "01" && verTo == "19") || (verFrom == "02" && verTo == "20")
                   || (verFrom == "19" && verTo == "01") || (verFrom == "20" && verTo == "02"))
                {
                    lblPrice.Text = "180.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya asuwayi");
                }
                else if ((verFrom == "01" && verTo == "20")
                   || (verFrom == "20" && verTo == "01"))
                {
                    lblPrice.Text = "190.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal ekasiya anuwayi");
                }
                else
                {
                    lblPrice.Text = "10.00";
                    spreader.SpeakAsync("ticket pathea mila rupiyal dhahayayi");
                }
            }
            else
            {

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("karunakara, arambhaka sthanaya, gamanaanthaya, dhumriya wargaya saha, dhumriya panthiya thooranna");
        }

        double  En;
 
       
        //send value to next page

        private void btnpay_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmSinPay frmSinP = new frmSinPay();

            frmSinP.En1 = lblPrice.Text;
            frmSinP.Show();
        }
    }
}
