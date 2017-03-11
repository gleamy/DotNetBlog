using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        //static LONGO.CommonModule.LogPackaging log = LONGO.CommonModule.LogPackaging.GetLog();

        static void Main(string[] args)
        {
            log4net.LogManager.GetLogger("mdc").Warn("");

            Console.ReadKey();
        }
    }
}
