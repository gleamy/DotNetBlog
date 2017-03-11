using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText(
                "abc.txt", "Begin..");

            for (int i = 0; i < 30; i++) {
                System.IO.File.WriteAllText(
               "abc.txt", i.ToString().PadRight(5) + DateTime.Now.ToString());
                System.Threading.Thread.Sleep(1000);
            }

            System.IO.File.WriteAllText(
                "abc.txt", "End..");
        }
    }
}
