using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Net;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            s.Connect(IPAddress.Parse("192.168.123.20"), 7712);
            s.Send(System.Text.Encoding.UTF8.GetBytes("中华人民共和国。"));
            s.Close();
        }
    }
}
