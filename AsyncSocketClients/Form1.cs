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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static AsyncSocketTCP.CustomEventArgs;



namespace AsyncSocketClients
{
    public partial class Form1 : Form
    {
        AsyncSocketTCPClient client = new AsyncSocketTCPClient();
     
        public Form1()
        {
            InitializeComponent();       
            
            client.ClientReceiveEvent += HandleClientReceive;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string strIPAddress = txtAddress.Text.Trim();
            string strPortInput = txtPort.Text.Trim();
            if (strIPAddress == "" || strPortInput == "")
            {
                strIPAddress = txtAddress.Text = "127.0.0.1";
                strPortInput = txtPort.Text = "9001";
            }
            if (!client.SetServerIPAddress(strIPAddress) || !client.SetPortNumber(strPortInput))
            {
                //txtMessenge.Text = string.Format("IP Address or port number invalid- {0} {1} Press a key to exit", client.ServerIPAddress, client.ServerPort);
                return;
            }
            client.ConnectToServer();

        }



        void HandleClientReceive(object sender, ClientReceiveEventArgs e)
        {
            //txtMessenge.Text += e.ClientRecieve + "\n";
            //lvMessenge.Items.Add(e.ClientRecieve);
            if (txtInput.Text == "")
            {
                return;
            }
            ListViewItem lvitem = new ListViewItem("Server");
            lvitem.SubItems.Add(DateTime.Now.ToString());
            lvitem.SubItems.Add(e.ClientRecieve);
            lvMessenge.Items.Add(lvitem);
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                return;
            }
            ListViewItem lvitem = new ListViewItem("Client");
            lvitem.SubItems.Add(DateTime.Now.ToString());
            lvitem.SubItems.Add(txtInput.Text);
            lvMessenge.Items.Add(lvitem);

            client.SendToServer(txtInput.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvMessenge.Items.Clear();
        }
    }
}
