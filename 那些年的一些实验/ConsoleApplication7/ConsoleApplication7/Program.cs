using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1970, 1, 1);
            Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

            Console.WriteLine(DateTime.Now.ToOADate());
        }
    }
}
