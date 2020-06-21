using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Programming_For_Clients
{
    public partial class Form1 : Form
    {
        TcpClient client = null;
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("192.168.88.42", 4000);
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            ServerMessage.Text = "Client: >>" + sr.ReadLine();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SendRequest_Click(object sender, EventArgs e)
        {
            if (SendText.Text != string.Empty)
            {
                NetworkStream ns = client.GetStream();
                StreamWriter sw = new StreamWriter(ns);

                sw.WriteLine(SendText.Text);
                sw.Flush();
                sw.Close();
                ns.Close();
            }
        }
    }
}
