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
using System.Media;

namespace Ket_noi
{
    public partial class Form1 : Form
    {
        private SoundPlayer choiNhac;
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer(@"C:\Users\DELL\Downloads\MA MA MA ZUONG.wav");
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (chkAmthanh.Checked)
            {
                choiNhac.Play();
            }
            else
                choiNhac.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkAmthanh.Visible = false;
            txtDataReceive.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int k = int.Parse(txtDataReceive.Text);
            
            if (k == 1)
            {
                chkAmthanh.Checked = true;
                lblHienthi.Text = "Light is on";
            }
            else
            {
                chkAmthanh.Checked = false;
                lblHienthi.Text = "Light is off";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Close();
            }    
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                btnKetNoi.Text = "Ngắt kết nối";
                serCOM.PortName = "COM5";
                serCOM.BaudRate = Convert.ToInt32("9600");
                serCOM.Open();
            }
            else
            {
                btnKetNoi.Text = "Kết nối";
                choiNhac.Stop();
                lblHienthi.Text = "";
                serCOM.Close();
            }
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String Alldata = "";
            Alldata = serCOM.ReadLine();
            int len = Alldata.Length;
            if (len > 0)
            {
                txtDataReceive.Text = Alldata;
            }
        }

        private void lblDocGT_Click(object sender, EventArgs e)
        {

        }

        private void lblHienthi_Click(object sender, EventArgs e)
        {
            
        }
    }
}