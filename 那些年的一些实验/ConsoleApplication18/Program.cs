using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            int i = 0;
            int j = 1;
            while (i < 10000 * 1000)
            {
                j = j * i;
                if (0 == i % 100)
                    j = 0;
                i++;
            }

            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}
