using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using ChatApp;

namespace Server
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
            byte[] data = new byte[1024];
            string stringData;
            User user = new User();
            user.Users("Test01", "abcdefghik");

            TcpListener newSoket = new TcpListener(IPAddress.Any, 9000 );
            newSoket.Start();
            Console.WriteLine("Dang cho client");


            TcpClient client = newSoket.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            Console.WriteLine(client.Client.RemoteEndPoint.ToString());

            int recv = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            string [] login = stringData.Split(',');
            if (user.checkUser(login[0], login [1]))
            {
                stringData = "Username or Password Wrong ";
                data = Encoding.ASCII.GetBytes(stringData);
                ns.Write(data, 0, data.Length);
            }

            string s = "Welcom to the sever";
            data = Encoding.ASCII.GetBytes(s);
            ns.Write(data, 0, data.Length);


            ns.Close();
            client.Close();
            newSoket.Stop();
            Console.ReadKey();*/
            EchoServer server = new EchoServer(9000);
        }

        
    }
}
