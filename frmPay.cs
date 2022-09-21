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
using System.IO;
using System.IO.Ports;
using System.Threading;
using ID003ProtocolManager;
using System.Drawing.Printing;

namespace TRainTicket2
{
    public partial class frmPay : Form
    {
        Thread comThread;
        SerialPort Port;
        ID003CommandCreater ComDll = new ID003CommandCreater();
        byte[] buffer = new byte[255];
        byte[] status = new byte[255];

        bool Active;
        int length;

        string fileLoc = @"D:\sample3.txt";

        private delegate void SetTextBox(byte[] text);

        string En;

        public string En1
        {
            get { return En; }
            set { En = value; }
        }


        public frmPay()
        {
            InitializeComponent();
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(data_received);//serial data handler
            Text = "ID003 Basic Driver " + Application.ProductVersion;
            Port = new SerialPort("COM3", 9600, Parity.Even, 8, StopBits.One);
           
        }



        double amount;


      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frmHom = new Form1();
            frmHom.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelect frmbk = new frmSelect();
            frmbk.Show();
        }

        SpeechSynthesizer spreader = new SpeechSynthesizer();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            spreader.SpeakAsync("ATTENTION! KIOSK GIVES NO CHANGE!");
        }

        double Price;

        private void frmPay_Load(object sender, EventArgs e)
        {
            lblPrice.Text = En1.ToString();
            spreader.SpeakAsync("ATTENTION! KIOSK GIVES NO CHANGE!");
            Price = Convert.ToDouble(En1);

            Active = true;
            Port.Open();
            comThread = new Thread(Poll);
            comThread.Start(); 
        }
        public void pollaction()
        {
            Active = true;
            Port.Open();
            comThread = new Thread(Poll);
            comThread.Start();
        }

        public void data_received(object sender, SerialDataReceivedEventArgs e)
        {

            int bytes;

            Thread.Sleep(20);
            bytes = Port.BytesToRead;
            byte[] dat = new byte[bytes];
            Port.Read(dat, 0, bytes);
            try
            {
                Thread.Sleep(10);
                this.BeginInvoke(new SetTextBox(si_DataReceived), new object[] { dat });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void si_DataReceived(byte[] data)
        {
            string dat = "";


        }
        /// </summary>

        private void Poll()
        {




            Actions.init(buffer, length, ComDll, Port);
            while (Active)
            {

                ComDll.StatusRequest(buffer);
                length = (int)buffer[1];
                Port.Write(buffer, 0, length);
                Port.Read(status, 0, 255);
                System.Threading.Thread.Sleep(100);
                switch (status[2])
                {

                    case 0x40:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x11:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x1A:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x13:
                        Actions.Accept(buffer, length, ComDll, Port);
                        switch (status[3])
                        {
                            case 0x61:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.10.00";
                                    Global.addvalue = 10;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount1 = Global.amount1 + 1;
                                   // label22.Text = Convert.ToString(Global.amount1);

                                });
                                break;
                            case 0x62:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.20.00";
                                    Global.addvalue = 20;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount2 = Global.amount2 + 1;
                                    //label23.Text = Convert.ToString(Global.amount2);
                                });
                                break;
                            case 0x63:
                                this.Invoke((MethodInvoker)delegate
                                {
                                   // label1.Text = "Rs.50.00";
                                    Global.addvalue = 50;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount3 = Global.amount3 + 1;
                                    //label24.Text = Convert.ToString(Global.amount3);
                                });
                                break;
                            case 0x64:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.100.00";
                                    Global.addvalue = 100;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount4 = Global.amount4 + 1;
                                  //  label25.Text = Convert.ToString(Global.amount4);
                                });
                                break;
                            case 0x66:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.500.00";
                                    Global.addvalue = 500;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount5 = Global.amount5 + 1;
                                    //label26.Text = Convert.ToString(Global.amount5);
                                });
                                break;
                            case 0x67:
                                this.Invoke((MethodInvoker)delegate
                                {
                                   // label1.Text = "Rs.1000.00";
                                    Global.addvalue = 1000;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount6 = Global.amount6 + 1;
                                    //label27.Text = Convert.ToString(Global.amount6);
                                });
                                break;
                            case 0x68:
                                this.Invoke((MethodInvoker)delegate
                                {
                                    //label1.Text = "Rs.2000.00";
                                    Global.addvalue = 2000;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount7 = Global.amount7 + 1;
                                    //label28.Text = Convert.ToString(Global.amount7);
                                });
                                break;
                            case 0x69:
                                this.Invoke((MethodInvoker)delegate
                                {
                                   // label1.Text = "Rs.5000.00";
                                    Global.addvalue = 5000;
                                    Global.total = Global.total + Global.addvalue;
                                    lblInse.Text = "Rs." + Global.total + ".00";
                                    Global.amount8 = Global.amount8 + 1;
                                    //label29.Text = Convert.ToString(Global.amount8);
                                });
                                break;
                        }
                        break;
                    case 0x17:
                        this.Invoke((MethodInvoker)delegate
                        {

                            Global.Ramount = Global.Ramount + 1;

                        });
                        break;
                    case 0x43:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x44:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x45:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x46:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x47:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x48:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x49:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;
                    case 0x4A:
                        this.Invoke((MethodInvoker)delegate
                        {

                        });
                        break;

                }


            }
        }
        private Font TimesNewRoman10Font;



        private void btnPay_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(Global.total);

            if (amount >= Price)
            {

                byte inhibit = 0x01;
                comThread.Suspend();
                ComDll.SetInhibit(buffer, inhibit);
                length = (int)buffer[1];
                Port.Write(buffer, 0, length);
                System.Threading.Thread.Sleep(100);
                comThread.Resume();





                Active = false;

                comThread.Abort();
                Port.Close();
                System.Threading.Thread.Sleep(500);



                /////////////////////

                FileStream fs = null;
                if (!File.Exists(fileLoc))
                {
                    using (fs = File.Create(fileLoc))
                    {

                    }
                }
                if (File.Exists(fileLoc))
                {
                    using (StreamWriter sw = new StreamWriter(fileLoc))
                    {
                        sw.Write("          ශ්‍රි ලංකා දුම්රිය දෙපාර්තමේන්තුව ");
                        sw.Write("\r\n");
                        sw.Write("                Sri Lanka railways");
                        sw.Write("\r\n");
                        sw.Write("             இலங்கை புகையிரத");
                        sw.Write("\r\n");
                        sw.Write("                 011-2505090");
                        sw.Write("\r\n");
                        sw.Write("   ");

                        sw.Write("\r\n");
                        sw.Write("   **********************************************");
                        sw.Write("\r\n");

                        sw.Write("             සිට / From / இருந்து");
                        sw.Write("\r\n");

                        sw.Write("               " + Global.LFrom.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("             දක්වා / To / செய்ய ");
                        sw.Write("\r\n");
                        sw.Write("               " + Global.LTo.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("           පංතිය / Class / வர்க்கம்");
                        sw.Write("\r\n");
                        sw.Write("               " + Global.LClass.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("          දුම්රිය වර්ගය / type of Train");
                        sw.Write("\r\n");
                        sw.Write("               / ரயில் வகை");
                        sw.Write("\r\n");
                        sw.Write("               " + Global.LType.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");

                        sw.Write("        ටිකට් පතේ මිළ / Price / விலை");
                        sw.Write("\r\n");
                        sw.Write("                   " + lblPrice.Text);
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("       ඇතුලත් කළ මුදල / Inserted Amount");
                        sw.Write("\r\n");
                        sw.Write("              / செருகிய அளவு");
                        sw.Write("\r\n");
                        sw.Write("                  " + lblInse.Text);
                        sw.Write("\r\n");


                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("   **********************************************");
                        sw.Write("\r\n");
                        sw.Write("                  ස්තුති Thank You நன்றி");
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("   **********************************************");

                    }
                }


                reader = new StreamReader(fileLoc);

                TimesNewRoman10Font = new Font("Times New Roman", 10);

                PrintDocument pd = new PrintDocument();

                pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);

                pd.Print();

                if (reader != null)
                    reader.Close();

                this.Hide();
                Form1 frmHom = new Form1();
                frmHom.Show();

            }
            else
            {
                MessageBox.Show("Inserted amount is not enough. ");
                byte inhibit = 0x01;
                comThread.Suspend();
                ComDll.SetInhibit(buffer, inhibit);
                length = (int)buffer[1];
                Port.Write(buffer, 0, length);
                System.Threading.Thread.Sleep(100);
                comThread.Resume();





                Active = false;

                comThread.Abort();
                Port.Close();
                System.Threading.Thread.Sleep(500);



                /////////////////////

                FileStream fs = null;
                if (!File.Exists(fileLoc))
                {
                    using (fs = File.Create(fileLoc))
                    {

                    }
                }
                if (File.Exists(fileLoc))
                {
                    using (StreamWriter sw = new StreamWriter(fileLoc))
                    {
                        sw.Write("          ශ්‍රි ලංකා දුම්රිය දෙපාර්තමේන්තුව ");
                        sw.Write("\r\n");
                        sw.Write("                Sri Lanka railways");
                        sw.Write("\r\n");
                        sw.Write("             இலங்கை புகையிரத");
                        sw.Write("\r\n");
                        sw.Write("                 011-2505090");
                        sw.Write("\r\n");
                        sw.Write("   ");

                        sw.Write("\r\n");
                        sw.Write("   **********************************************");
                        sw.Write("\r\n");

                        sw.Write("             සිට / From / இருந்து");
                        sw.Write("\r\n");

                        sw.Write("               " + Global.LFrom.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("             දක්වා / To / செய்ய ");
                        sw.Write("\r\n");
                        sw.Write("               " + Global.LTo.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("           පංතිය / Class / வர்க்கம்");
                        sw.Write("\r\n");
                        sw.Write("               " + Global.LClass.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("          දුම්රිය වර්ගය / type of Train");
                        sw.Write("\r\n");
                        sw.Write("               / ரயில் வகை");
                        sw.Write("\r\n");
                        sw.Write("               " + Global.LType.ToString());
                        sw.Write("\r\n");
                        sw.Write("\r\n");

                        sw.Write("        ටිකට් පතේ මිළ / Price / விலை");
                        sw.Write("\r\n");
                        sw.Write("                   " + lblPrice.Text);
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("       ඇතුලත් කළ මුදල / Inserted Amount");
                        sw.Write("\r\n");
                        sw.Write("              / செருகிய அளவு");
                        sw.Write("\r\n");
                        sw.Write("                  " + lblInse.Text);
                        sw.Write("\r\n");


                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("   **********************************************");
                        sw.Write("\r\n");
                        sw.Write("                  ස්තුති Thank You நன்றி");
                        sw.Write("\r\n");
                        sw.Write("\r\n");
                        sw.Write("   **********************************************");

                    }
                }


                reader = new StreamReader(fileLoc);

                TimesNewRoman10Font = new Font("Times New Roman", 10);

                PrintDocument pd = new PrintDocument();

                pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);

                pd.Print();

                if (reader != null)
                    reader.Close();

                this.Hide();
                Form1 frmHom = new Form1();
                frmHom.Show();
            }
        }
        private StreamReader reader;

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {

            Font printFont = new Font("Arial", 10);
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;

            float leftMargin = ppeArgs.MarginBounds.X - 100;

            float topMargin = ppeArgs.MarginBounds.Y - 100;
            string line = null;

            linesPerPage = ppeArgs.MarginBounds.Height / TimesNewRoman10Font.GetHeight(g);

            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ppeArgs.Graphics));
                ppeArgs.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }

            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }

            //----------------------------------------------------------------------


        }
    }
}
