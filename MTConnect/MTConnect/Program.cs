using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTConnect
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 1)
            {
                new ConsoleService() { AgentAddress = args[0], MonitorAddress = args[1] }.Start();
                string commend = null;
                do
                {
                    commend = Console.ReadLine();
                } while (commend == null || commend.Trim().ToUpper() != "EXIT");
            }
            else
            {
                //new Test().Start();

                //Console.ReadLine();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
