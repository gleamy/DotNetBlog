using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using LONGO.CommonModule;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            //UInt16.MaxValue

            //TestRegax();

            //String filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

            //Console.WriteLine(filePath);

            //TestFileCache();
            //RestartBCNET();
            TestRunning();
            //Console.ReadKey();
        }

        private static void TestRunning() 
        {
            Thread t = new Thread(
                o =>
                {
                    while (true)
                    {
                        Console.WriteLine(DateTime.Now);
                        Thread.Sleep(1000 * 5);
                    }
                }) { IsBackground = true };

            t.Start(null);

            Console.ReadKey();        
        }

        static void RestartBCNET()
        {
            string html = null;
            using (CNNWebClient wc = new CNNWebClient())
            {
                wc.Timeout = 5;
                byte[] b = wc.DownloadData("http://" + Environment.GetCommandLineArgs()[1] + "/config1.shtml");
                html = Encoding.GetEncoding("GB2312").GetString(b, 0, b.Length);
                var para = BuildParams(html);
                try
                {
                    wc.DownloadData("http://" + Environment.GetCommandLineArgs()[1] + "/S7config.cgi?" + para);
                }
                catch (Exception e)
                { 
                    // - 
                }
            }
            Console.Write(html);
        }

        static Dictionary<string, string> FineParams(string html) {
           
            string[] paramNames = new string[] { "TS_S", "HS_S", "RETRY_S", 
                "GAP_S", "PLCADDR_S", "DBNO_S", "S7MODE_S" };
            Dictionary<string, string> value = new Dictionary<string, string>(7);
            foreach(string name in paramNames)
            {
                Match m = Regex.Match(html, @"var\s+" + name + @"\s*=\s*\d*\s*;");
                value.Add(name, m.Value.Substring(m.Value.LastIndexOf('=') + 1).Trim(' ', ';'));
            }
            return value;
        }

        static string BuildParams(string html)
        {
            #region MyRegion
            //var TS_S = 17;
            //var HS_S = 31;
            //var RETRY_S = 3;
            //var GAP_S = 10;
            //var PLCADDR_S = 2;
            //var DBNO_S = 1;
            //var S7MODE_S = 1;
            //---------------------
            //var TS = 0;
            //var HS = 31;
            //var RETRY = 3;
            //var GAP = 10;
            //var ACCE = 0;
            //var PROTOCOL = 2;
            //var BAUD = 0;
            //var QUERY = 0;
            #endregion

            string[] paramNames = new string[] { 
                "TS_S", "HS_S", "RETRY_S", "GAP_S", "PLCADDR_S", "DBNO_S", "S7MODE_S", // - 老版 
                "TS", "HS", "RETRY", "GAP", "ACCE", "PROTOCOL", "BAUD", "QUERY" // - 新版
            };

            StringBuilder sb = new StringBuilder();
            foreach (string name in paramNames)
            {
                Match m = Regex.Match(html, @"var\s+" + name + @"\s*=\s*\d*\s*;");
                if (m == null || string.IsNullOrEmpty(m.Value))
                    continue;
                sb.Append(name)
                    .Append('=')
                    .Append(m.Value.Substring(m.Value.LastIndexOf('=') + 1).Trim(' ', ';'))
                    .Append("&");
            }
            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        static void TestRegax() 
        {
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sk.Connect(new IPEndPoint(new IPAddress(new byte[] { 61, 135, 169, 121 }), 80));
            string ip = sk.RemoteEndPoint.ToString();
            Console.WriteLine(ip.Substring(0, ip.LastIndexOf(':')));
            string str;
            string value = null;
            using (WebClient wc = new WebClient()) {
                byte[] b = wc.DownloadData("file:///G:/%E5%AE%A2%E6%88%B7%E8%B5%84%E6%96%99/%E6%BB%A8%E5%B7%9E_%E7%9B%9F%E5%A8%81%E6%88%B4%E5%8D%A1/BCNET%E5%93%8D%E5%BA%94%E5%BC%82%E5%B8%B8%E9%97%AE%E9%A2%98%E8%A7%A3%E5%86%B3/bcnet/bcnet/%E8%A5%BF%E9%97%A8%E5%AD%90%E4%BB%A5%E5%A4%AA%E7%BD%91%E9%80%9A%E8%AE%AF%E5%A4%84%E7%90%86%E5%99%A8SCANET-S7.htm");
                str = Encoding.GetEncoding("GB2312").GetString(b, 0, b.Length);
                
            }
            System.Text.RegularExpressions.Match m =
            System.Text.RegularExpressions.Regex.Match(str, "<!--#S7ERR-->[0-9]*");
            if (m != null && m.Index != -1) 
            {
                value = m.Value;
                value = value.Substring(value.LastIndexOf('>') + 1);
            }

            Console.WriteLine(value);

            //WebRequest wr = HttpWebRequest.Create("http://www.baidu.com");
            //WebResponse resp =  wr.GetResponse();
            //resp.GetResponseStream().BeginRead
        }


        static void TestFileCache() 
        {
            var fc =
            RealtimeFileCache.GetInstance("hahaha-abc");
            Console.WriteLine("abc-a : " + fc.Get("abc-a"));
            Console.WriteLine("abc-b : " + fc.Get("abc-b"));
            Console.WriteLine("abc-c : " + fc.Get("abc-c"));

            fc.Set("abc-a", DateTime.Now.ToLongDateString());
            fc.Set("abc-b", DateTime.Now.ToLongTimeString());
            fc.Set("abc-c", DateTime.Now.ToFileTimeUtc().ToString());

            for (int i = 0; i < 2000; i++)
            {
                fc.Set("i-" + i % 10,
                    i.ToString().PadLeft(10)
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            for (int i = 0; i < 2000; i++)
            {
                Console.WriteLine(fc.Get("i-" + i % 10));
            }
        }
    }
}
