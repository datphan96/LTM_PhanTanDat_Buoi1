using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace PhanTanDat_b2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Input hostname or ip address : ");
                string host = Console.ReadLine();

                IPHostEntry iphost = Dns.GetHostEntry(host);
                Console.WriteLine("Hostname: {0}", iphost.HostName);


            foreach (string s in iphost.Aliases)
            {
                Console.WriteLine("\t+ Alias: {0} \n", s);
            }

            foreach (IPAddress i in iphost.AddressList)
            {
                Console.WriteLine("\t+ IP: {0}", i);
            }

            Console.ReadLine();
        }
    }
}
