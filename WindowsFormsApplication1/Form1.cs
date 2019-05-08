using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        Label[,] arrlab = null;
        
        string dataIn;
        delegate void SetTextCallback(string text);
        private void timer1_Tick(object sender, EventArgs e)
        {
            ConvertData();
        }


        void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                dataIn = serialPort1.ReadLine();
                SetText(dataIn);
            }
            catch
            {

            }
        }
        private void SetText(string text)
        {

            if (this.lblRequired.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(SetText);

                this.Invoke(d, new object[] { text });               
            }

            else this.lblRequired.Text = text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            
            int dong = Setting.Settingport.Row;
            int cot = Setting.Settingport.Column;
            arrlab = new Label[dong, cot];
            for(int i=0; i<arrlab.GetLength(0);i++)
            {
                for (int j = 0; j < arrlab.GetLength(1); j++)
                {
                    Label lb= new Label();
                    lb.Width = lb.Height = 50;
                    lb.BackColor = Color.CadetBlue;
                    lb.Location = new Point(i * (lb.Width+3), j * (lb.Height+3));
                    pnlLabel.Controls.Add(lb);
                    arrlab[i, j] = lb;
                }
            }
            
            try
            {
                serialPort1.PortName = Setting.Settingport.Com;
                serialPort1.BaudRate = Setting.Settingport.Baud;
                serialPort1.DataBits = Convert.ToInt32("8");
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                serialPort1.Open();

            }
            catch
            {              
            }

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
        }
        private void ConvertData()
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    string lbli,lblj;
                    string bit;
                    lbli = dataIn.Substring(0,1);
                    lblj = dataIn.Substring(2,1); 
                    bit = dataIn.Substring(4, 1);
                    int Y = Convert.ToInt32(lbli)-1;
                    int X = Convert.ToInt32(lblj)-1;
                    
                    if (bit == "1")
                    {
                        arrlab[X, Y].BackColor = Color.Chartreuse;
                    }
                    if (bit == "0")
                    {
                        arrlab[X, Y].BackColor = Color.Red;
                    }
                }
                catch { }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting frm = new Setting();
            frm.Show();
            this.Close();
        }
    }
}
