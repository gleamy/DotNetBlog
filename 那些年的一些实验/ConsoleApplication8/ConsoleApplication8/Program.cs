using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1119638520;
            
            var b = BitConverter.GetBytes(n);

            var f =
            BitConverter.ToSingle(b,0);


            Console.WriteLine(f);

            Console.ReadKey();

        }
    }
}
