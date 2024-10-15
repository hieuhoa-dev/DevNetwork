using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSocketTCP
{
    public class CustomEventArgs
    {
        public class ClientConnectedEventArgs : EventArgs
        {
            public string NewClient { get; set; }
            public ClientConnectedEventArgs(string _newClient)
            {
                NewClient= _newClient;

            }
        }
        public class ClientDisConnectedEventArgs : EventArgs
        {
            public string DisconnectedClient { get; set; }
            public ClientDisConnectedEventArgs(string _disconnectedClient)
            {
                DisconnectedClient = _disconnectedClient;
            }
        }

        public class ClientReceiveEventArgs : EventArgs
        {
            public string ClientRecieve { get; set; }
            public ClientReceiveEventArgs(string _ClientRecieve)
            {
                ClientRecieve = _ClientRecieve;
            }
        }

        public class ServerReceiveEventArgs : EventArgs
        {
            public string ServerRecieve { get; set; }
            public ServerReceiveEventArgs(string _ServerRecieve)
            {
                ServerRecieve = _ServerRecieve;
            }
        }


    }
}
