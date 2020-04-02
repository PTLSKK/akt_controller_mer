using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace AKTController_
{
    public partial class Form1 : Form
    {
        IPEndPoint endM1;
        UdpClient udpM1;
        byte[] bytesM1;

        public Form1()
        {
            InitializeComponent();

            //Meriam 1
            udpM1 = new UdpClient();
            endM1 = new IPEndPoint(IPAddress.Parse("192.168.1.16"), 1016);
            udpM1.Connect(endM1);
            
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpM1.Close();
        }

        private void M1_R_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("R");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_S_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("S");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_J_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("J");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Up1_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("U1");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Dwn1_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("D1");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Lft1_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("L1");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Rgt1_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("R1");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Up2_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("U2");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Dwn2_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("D2");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Lft2_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("L2");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Rgt2_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("R2");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Up3_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("U3");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Dwn3_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("D3");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Lft3_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("L3");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Rgt3_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("R3");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Stop_Tilt_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("ST1");
            udpM1.Send(bytesM1, bytesM1.Length);
        }

        private void M1_Stop_Rotate_Click(object sender, EventArgs e)
        {
            bytesM1 = Encoding.ASCII.GetBytes("SR1");
            udpM1.Send(bytesM1, bytesM1.Length);
        }
    }
}
