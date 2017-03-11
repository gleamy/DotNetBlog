using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    delegate void DLG(string str);

    class Program
    {
        static void Main(string[] args)
        {
            DLG
            d = new DLG(m_1);
            d("abc");

            d = new DLG(m_2);
            d("def");

            Console.ReadLine();
        }

        static void m_1(string str)
        {
            Console.WriteLine("in m_1 method." + str);
        }

        static void m_2(string str)
        {
            Console.WriteLine("in m_2 method." + str);
        }
    }
}
