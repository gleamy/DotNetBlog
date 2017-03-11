using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication24
{
    class Program
    {
        public static System.Threading.Mutex _run;

        [STAThread]
        static void Main2(string[] args)
        {
            bool createdNew = false;
            _run = new System.Threading.Mutex(true, "MDC.PlugIn.DealStatus", out createdNew);
            Console.WriteLine(createdNew);
            Console.ReadKey();

        }

        public static System.IO.Stream stream = null;

        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                using (
                    stream = System.IO.File.Open(
                    Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\abc.abc",
                    System.IO.FileMode.OpenOrCreate, 
                    System.IO.FileAccess.Read, 
                    System.IO.FileShare.None
                ))
                {
                    Console.WriteLine("OPEND.");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                System.Threading.Thread.Sleep(1000 * 10);
            }

        }
    }
}
