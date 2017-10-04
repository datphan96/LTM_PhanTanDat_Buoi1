using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PhanTanDat_b3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[4];
            for (int i = 0; i < a.Length; i++)
                a[i] = 10;
            IPAddress ip = new IPAddress(a);
            Console.WriteLine("IP: {0}", ip);
            Console.WriteLine("Any: {0}", IPAddress.Any);
            Console.WriteLine("Broadcast: {0}", IPAddress.Broadcast);
            Console.WriteLine("Loopback: {0}", IPAddress.Loopback);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("123.123.12.13"), 12345);
            Console.WriteLine("IpEndpoint: {0}", ipe);
            Console.WriteLine("IP: {0}", ipe.Address);
            Console.WriteLine("IP: {0}", ip.AddressFamily);

            IPHostEntry iphe = Dns.GetHostEntry("www.google.com");
            Console.WriteLine("IP: {0}", iphe);
            Console.ReadLine();
        }
    }
}
