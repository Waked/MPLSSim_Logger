using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MPLSSim_Logger
{
    public static class LoggingLib
    {
        private static int remotePort = 60000;
        private static Socket socket;
        private static IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        private static IPEndPoint remoteEP = new IPEndPoint(ipAddress, remotePort);

        public static void Connect()
        {
            if (socket == null)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            }
        }

        public static void SetPort(int port)
        {
            remotePort = port;
            remoteEP.Port = port;
        }

        public static void SendMessage(string msg)
        {
            if (socket != null)
            {
                socket.SendTo(Encoding.ASCII.GetBytes(msg), remoteEP);
            }
        }
    }
}
