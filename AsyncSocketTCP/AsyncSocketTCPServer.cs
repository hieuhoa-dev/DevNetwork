﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Remoting.Messaging;
using static AsyncSocketTCP.CustomEventArgs;
using System.Runtime.InteropServices;

namespace AsyncSocketTCP
{
    public class AsyncSocketTCPServer
    {
        IPAddress mIP;
        int mPort;
        TcpListener mTCPListener;
        List<TcpClient> mClients;
        //Lấy trạng thái chương trình đang thực thì hay không?


        public bool KeepRunning { get; set; }

        public AsyncSocketTCPServer()
        {
            mClients = new List<TcpClient>();
        }

        public async void StartListeningForIncomingConnection(IPAddress ipaddr = null, int port = 9001)
        {

            if (ipaddr == null)
                ipaddr = IPAddress.Any;

            if (port <= 0)
                port = 9001;

            mIP = ipaddr;
            mPort = port;
            System.Diagnostics.Debug.WriteLine(string.Format("IP Address: [0] Port: [1]", mIP.ToString(), mPort));
            mTCPListener = new TcpListener(mIP, mPort);
            try
            {
                mTCPListener.Start();
                KeepRunning = true;

                while (KeepRunning)
                {
                    var returnedByAccept = await mTCPListener.AcceptTcpClientAsync();
                    mClients.Add(returnedByAccept);
                    OnClientConnectedEvent(new ClientConnectedEventArgs(returnedByAccept.Client.RemoteEndPoint.ToString()));
                    Debug.WriteLine(
                        string.Format("Client connected successfully, count: {0}-{1}",
                        mClients.Count, returnedByAccept.Client.RemoteEndPoint)
                         );
                    TakeCareOfTCPClient(returnedByAccept);
                    //Recieve(returnedByAccept.Client);
                }
            }
            catch (Exception excp)
            {
                System.Diagnostics.Debug.WriteLine(excp.ToString());
            }


        }
        private void RemoveClient(TcpClient paramClient)
        {
            if (mClients.Contains(paramClient))
            {
                mClients.Remove(paramClient);
                OnClientDisConnectedEvent(new ClientDisConnectedEventArgs(paramClient.Client.RemoteEndPoint.ToString()));
                Debug.WriteLine(String.Format("Client removed, count: {0}", mClients.Count));
            }
        }


        private async void TakeCareOfTCPClient(TcpClient paramClient)
        {
            NetworkStream stream = null;
            StreamReader reader = null;
            try
            {
                stream = paramClient.GetStream();
                reader = new StreamReader(stream);
                char[] buff = new char[64];
                while (KeepRunning)
                {
                    Debug.WriteLine("*** Ready to read");
                    int nRet = await reader.ReadAsync(buff, 0, buff.Length);
                    System.Diagnostics.Debug.WriteLine("Returned: " + nRet);
                    if (nRet == 0)
                    {
                        RemoveClient(paramClient);
                        System.Diagnostics.Debug.WriteLine("Socket disconnected");
                        break;
                    }
                    string receivedText = new string(buff);
                    //OnCLick();
                    OnServerReceiveEventEvent(new ServerReceiveEventArgs(receivedText));
                    System.Diagnostics.Debug.WriteLine("*** RECEIVED: + receivedText");

                    Array.Clear(buff, 8, buff.Length);  
                }
            }
            catch (Exception excp)
            {
                RemoveClient(paramClient);
                System.Diagnostics.Debug.WriteLine(excp.ToString());
            }
        }
        //void Recieve(Socket client)
        //{
        //    while (true)
        //    {  
        //        byte[] recv = new byte[1024];
        //        client.Receive(recv);
        //        string s = Encoding.UTF8.GetString(recv);
        //        OnServerReceiveEventEvent(new ServerReceiveEventArgs(s));
        //    }
        //}

        public async void SendToAll(string leMessege)
        {
            if (string.IsNullOrEmpty(leMessege))
                return;
            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(leMessege);
                foreach (TcpClient c in mClients)
                    await c.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
            }
            catch (Exception excp)
            {
                Debug.WriteLine(excp.ToString());
            }
        }
        public void StopServer()
        {
            try
            {
                if (mTCPListener != null)
                    mTCPListener.Stop();

                foreach (TcpClient c in mClients)
                    c.Close();

                mClients.Clear();
            }
            catch (Exception excp)
            {
                Debug.WriteLine(excp.ToString());
            }

        }
        public EventHandler<ClientConnectedEventArgs> ClientConnectedEvent;

        protected virtual void OnClientConnectedEvent(ClientConnectedEventArgs e)
        {
            EventHandler<ClientConnectedEventArgs> handler = ClientConnectedEvent;
            if (handler != null)
            {
                handler(this, e);
            }

        }

        public int Count()
        {
            return mClients.Count;
        }


        public EventHandler<ClientDisConnectedEventArgs> ClientDisConnectedEvent;

        protected virtual void OnClientDisConnectedEvent(ClientDisConnectedEventArgs e)
        {
            EventHandler<ClientDisConnectedEventArgs> handler = ClientDisConnectedEvent;
            if (handler != null)
            {
                handler(this, e);
            }

        }
        public EventHandler<ServerReceiveEventArgs> ServerReceiveEvent;

        protected virtual void OnServerReceiveEventEvent(ServerReceiveEventArgs e)
        {
            EventHandler<ServerReceiveEventArgs> handler = ServerReceiveEvent;
            if (handler != null)
            {
                handler(this, e);
            }

        }




    }
}

