using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncSocketTCP;
using static AsyncSocketTCP.CustomEventArgs;



namespace AsyncSocketClients
{
    public partial class Form1 : Form
    {
        AsyncSocketTCPClient client = new AsyncSocketTCPClient();
     
        public Form1()
        {
            InitializeComponent();
            client.ClientReceiveEvent += HandleClientDisConnected;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string strIPAddress = txtAddress.Text;
            string strPortInput = txtPort.Text;
            if (strIPAddress == "" || txtPort.Text == "")
            {
                strIPAddress = txtAddress.Text = "127.0.0.1";
                strPortInput = txtPort.Text = "9001";
            }
            if (!client.SetServerIPAddress(strIPAddress) || !client.SetPortNumber(strPortInput))
            {
                txtMessenge.Text = string.Format("IP Address or port number invalid- {0} {1} Press a key to exit", client.ServerIPAddress, client.ServerPort);
                return;
            }
            client.ConnectToServer();
        }


        //void HandleClientRecive(object sender, ClientConnectedEventArgs e)
        //{
        //    txtMessenge.AppendText(string.Format("{0} New client connected {1}\r\n", DateTime.Now, e.NewClient));
        //}

        private void OnHandleClientRecive(object sender, EventArgs e)
        {
            txtMessenge.Text += client.dataReceive+"\n";
        }
        void HandleClientDisConnected(object sender, ClientReceiveEventArgs e)
        {  
            txtMessenge.Text += e.ClientRecieve + "\n";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.SendToServer(txtInput.Text);
        }
    }
}
