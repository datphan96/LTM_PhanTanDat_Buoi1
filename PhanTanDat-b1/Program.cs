using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace PhanTanDat_b1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lấy tất cả địa chỉ IPv4 và IPv6 của máy
            //string HostName = Dns.GetHostName();
            //Console.WriteLine("Computer name is :" + HostName);
            //IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);
            //Console.WriteLine("IP Address are :");
            //foreach (IPAddress ip in ipaddress)
            //{
            //    Console.WriteLine(ip.ToString());
            //}
            //Lấy địa chỉ IPv4 của máy
            string HostName = Dns.GetHostName();
            Console.WriteLine("Computer name =" + HostName);
            IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);
            Console.WriteLine("IPv4 of your computer are ");
            foreach (IPAddress ipv4 in ipaddress.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
            {
                Console.WriteLine(ipv4.ToString());
            }
            Console.ReadLine();
        }
    }
}
