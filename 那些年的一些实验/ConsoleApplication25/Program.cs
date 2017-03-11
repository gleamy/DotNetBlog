using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args != null)
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
