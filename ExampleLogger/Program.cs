using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MPLSSim_Logger
{
    class Program
    {
        private static void Log(Object state)
        {
            LoggingLib.SendMessage("Test message");
        }

        static void Main(string[] args)
        {
            LoggingLib.Connect();
            Timer logger = new Timer(Log, null, 0, 1000);
            while (true)
            {

            }
        }
    }
}
