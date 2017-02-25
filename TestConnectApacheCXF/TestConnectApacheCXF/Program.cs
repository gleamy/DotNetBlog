using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestConnectApacheCXF.ServiceReference1;

namespace TestConnectApacheCXF
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestClient tc = new ServiceReference1.TestClient();
            var v = tc.HelloOne();
            Console.WriteLine(v.Length);

            var v2 = tc.HelloTwo("a");

            var v3 = tc.HelloThree(10, 15);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
