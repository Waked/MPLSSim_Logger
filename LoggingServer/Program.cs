using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPLSSim_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> config = new Dictionary<string, string>();

            foreach (string param in args)
            {
                string[] decomposed = param.Split('='); // Split key=value
                decomposed[0].Trim('-'); // Remove any leading dashes
                config.Add(decomposed[0], decomposed[1]); // Add key,value pair to the dictionary
            }

            try
            {
                LoggingServer server = new LoggingServer(Int32.Parse(config["port"]));
            }
            catch (Exception)
            {
                Console.WriteLine("Could not start server.");
                Console.ReadKey();
            }
        }
    }
}
