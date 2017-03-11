using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Double> d = new List<double>();

            for (int i = 0; i < 10000; i++)
            {
                d.Add(i * 1.3333312);
            }

            Console.WriteLine(d.ToArray().Length);

            Console.ReadKey();
        }
    }
}
