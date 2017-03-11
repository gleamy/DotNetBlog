using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            //string abc = "123";
            //Console.WriteLine(abc.Contains("O") | abc.Contains("o"));
            //Console.ReadKey();

            for (int i = 0; i < 10000 * 10; i++)
            {
                String str =
                    HttpPost("http://127.0.0.1:15031/put",
                    "p=12&n=abc&v=" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "\r\n");
                Thread.Sleep(20);
            }

            //Console.WriteLine(str);
        }


        private static string HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            //request.CookieContainer = cookie;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //response.Cookies = cookie.GetCookies(response.ResponseUri);
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
    }
}
