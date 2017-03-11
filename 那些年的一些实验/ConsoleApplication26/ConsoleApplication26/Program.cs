using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApplication26
{
    class Program
    {
        public static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(Program));

        static System.Threading.Thread _thread = null;

        static void Main(string[] args)
        {
            _thread = new System.Threading.Thread(ThreadWork) { IsBackground = true };
            _thread.Start();

            while (Console.ReadLine().Trim().ToLower() != "exit") ;
        }

        static void ThreadWork() 
        {
            while (true)
            {
                _logger
                    .Info(Process.GetCurrentProcess().MainModule.FileName + " - " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                System.Threading.Thread.Sleep(1000 * 5);
            }
        }

        static void Main___(string[] args) 
        {
            byte[] b = new byte[10];
            for (int i = 0; i < 257; i++)
            {
                b[5]++;
                Console.WriteLine(b[5]);
            }

            Console.WriteLine(SocketError.AccessDenied.ToString());
            Console.ReadKey();
        }

        static void Main__(string[] args)
        {
            string db_Cnt = "TNS:IP=192.168.1.1;PORT=1521;SERVICE_NAME=ORCL;USER_ID=lmdc60;PASSWORD=lmdc";
            if (db_Cnt.StartsWith("TNS:", StringComparison.CurrentCultureIgnoreCase))
            {
                string str = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVICE_NAME={2})));User ID={3};Password={4}";
                string ip = "127.0.0.1";
                string port = "1521";
                string service_name = "orcl";
                string user_id = null;
                string password = null;
                db_Cnt = db_Cnt.Remove(0, 4).Trim();
                string[] parameters = db_Cnt.Split(';');
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i] == null)
                        continue;
                    string item = parameters[i].Trim();
                    if (item == string.Empty)
                        continue;
                    int s_index = item.IndexOf('=');
                    if (s_index == -1)
                        continue;
                    if (item.StartsWith("ip", StringComparison.CurrentCultureIgnoreCase))
                        ip = item.Substring(s_index + 1).Trim();
                    else if (item.StartsWith("port", StringComparison.CurrentCultureIgnoreCase))
                        port = item.Substring(s_index + 1).Trim();
                    else if (item.StartsWith("service_name", StringComparison.CurrentCultureIgnoreCase))
                        service_name = item.Substring(s_index + 1).Trim();
                    else if (item.StartsWith("user_id", StringComparison.CurrentCultureIgnoreCase))
                        user_id = item.Substring(s_index + 1).Trim();
                    else if (item.StartsWith("password", StringComparison.CurrentCultureIgnoreCase))
                        password = user_id = item.Substring(s_index + 1).Trim();
                }
                db_Cnt = string.Format(str, ip, port, service_name, user_id, password);
            }
        }
        
    }
}
