using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtmessage.Invoke((MethodInvoker)delegate ()
            {
                txtmessage.Text += e.MessageString;
            });
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            btnstart.Enabled = false;
          
            client.Connect(txthost.Text, Convert.ToInt32(txtport.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtmessage.Text,TimeSpan.FromSeconds(3));
        }
    }
}
