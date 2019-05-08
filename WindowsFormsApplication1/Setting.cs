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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                cbxPort.DataSource = SerialPort.GetPortNames();
            }
            catch { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbxPort.Text!=""&& cbxBaud.Text != "" && cbxColumn.Text != "" && cbxRow.Text != "")
            {
                Settingport.Com = cbxPort.Text;
                Settingport.Baud = Convert.ToInt32(cbxBaud.Text);
                Settingport.Column = Convert.ToInt32(cbxColumn.Text);
                Settingport.Row = Convert.ToInt32(cbxRow.Text);
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ban chua chon xong?", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static class Settingport
        {
            public static string Com;
            public static int Baud;
            public static int Column;
            public static int Row;
        }

        private void cbxPort_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbxPort.DataSource = SerialPort.GetPortNames();
            }
            catch { }
        }
        
    }
}
