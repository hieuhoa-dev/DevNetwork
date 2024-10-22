using AsyncSocketTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AsyncSocketTCP.CustomEventArgs;

namespace Lab6_1
{
    public partial class AsyncSocketServer : Form
    {
        AsyncSocketTCPServer mServer;
        public AsyncSocketServer()
        {
            InitializeComponent();
            mServer = new AsyncSocketTCPServer();
            mServer.ClientConnectedEvent += HandleClientConnected;
            mServer.ClientDisConnectedEvent += HandleClientDisConnected;
            mServer.ServerReceiveEvent += HandleServerReceive;


        }

        private void btnAcceptIncomingAsync_Click(object sender, EventArgs e)
        {
            mServer.StartListeningForIncomingConnection();
        }


        public void btnSendAll_Click(object sender, EventArgs e)
        {
  
            mServer.SendToAll(txtMessage.Text.Trim());
          
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            mServer.StopServer();
            txtClients.Text = "0";
        }

        private void Forml_FormClosing(object sender, FormClosingEventArgs e)
        {
            mServer.StopServer();
        }

        void HandleClientConnected(object sender, ClientConnectedEventArgs e)
        {
            txtClientInfo.AppendText(string.Format("{0} New client connected {1}\r\n", DateTime.Now, e.NewClient));
            txtClients.Text = mServer.Count().ToString();
        }
        void HandleClientDisConnected(object sender, ClientDisConnectedEventArgs e)
        {
            txtClientInfo.AppendText(string.Format("{0} Client had disconnected {1}\r\n", DateTime.Now, e.DisconnectedClient));
            txtClients.Text = mServer.Count().ToString();
        }
        void HandleServerReceive(object sender, ServerReceiveEventArgs e)
        {
            //txtMessenge.Text += e.ServerRecieve +"\n\r";
            lvMessenge.Items.Add(e.ServerRecieve);
        }

    }
}
