using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperWebSocket;

namespace Socket1
{
    class Program
    {
        private static WebSocketServer servidorSocket;
        static void Main(string[] args)
        {
            servidorSocket = new WebSocketServer();
            int puerto = 8088;
            servidorSocket.Setup(puerto);
            servidorSocket.NewSessionConnected += servidorSocket.NewSessionConnected
                
        }
    }
}
