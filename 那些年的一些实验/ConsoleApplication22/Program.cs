using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc =
                new Scanner("192.168.1.210", 23);
            Console.ReadKey();
        }
    }

    class Scanner
    {
        private System.Threading.Thread _t = null;
        private string _ip;
        private int  _port;
        private Socket _sk = null;

        public Scanner(string ip, int port)
        {
            _ip   = ip;
            _port = port;

            var remoteEP = new IPEndPoint(IPAddress.Parse(ip), port);
            _sk = new Socket(remoteEP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _sk.Connect(remoteEP);
            _t = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(Run)) { IsBackground = true };
            _t.Start(_sk);
        }

        private void Run(object o)
        {
            var sk = o as Socket;
            try
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    var rec = sk.Receive(buffer);
                    Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, rec - 1));
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
    }
}
