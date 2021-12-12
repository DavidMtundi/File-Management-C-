using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdvancedProject.Forms
{
    public partial class SocketProgramming : Form
    {
        public SocketProgramming()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void loadserver()
        {
          
        }

        private void SocketProgramming_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived; ;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtmessage.Invoke((MethodInvoker)delegate ()
            {
                txtmessage.Text += e.MessageString;
                e.ReplyLine(string.Format("You said:{0}     ", e.MessageString));
            });
            //throw new NotImplementedException();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            txtmessage.Text += "server starting .....";
            System.Net.IPAddress ip =  System.Net.IPAddress.Parse(txthost.Text);
            server.Start(ip, Convert.ToInt32(txtport.Text));
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {

                server.Stop();
            }
        }
    }
}
