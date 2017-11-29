using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace MPLSSim_Logger
{
    class LoggingServer
    {
        int port;
        Stopwatch time;
        StyleSheet style;
        public string ElapsedTime
        {
            get
            {
                return String.Format("{0:00}:{1:00}.{2:000} ", time.Elapsed.Minutes, time.Elapsed.Seconds, time.Elapsed.Milliseconds);
            }
        }

        public LoggingServer(int port)
        {
            this.port = port;
            Init();
        }

        private void Init()
        {
            time = new Stopwatch();
            style = new StyleSheet(System.Drawing.Color.LightGray);
            Thread listenerThread = new Thread(StartListener);
            while (true)
            {
                try
                {
                    listenerThread.Start();
                    listenerThread.Join();
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void StartListener()
        {
            bool done = false;

            UdpClient listener = new UdpClient(port);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, port);

            try
            {
                while (!done)
                {
                    byte[] bytes = listener.Receive(ref groupEP);
                    string msg = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    Console.WriteLineStyled(style, ElapsedTime + "Received: {0}", msg);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }
    }
}
