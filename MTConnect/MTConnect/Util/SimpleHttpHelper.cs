using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace MTConnect.Util
{
    public class SimpleHttpHelper
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(SimpleHttpHelper));

        public static SimpleHttpHelper GetInstance() {
            return ObjectFactory.GetInstance().GetObject<SimpleHttpHelper>();
        }

        public string RequestURL(String url, string method, string param) 
        {
            HttpWebRequest _webRequest = null;
            _webRequest = (HttpWebRequest)WebRequest.Create(new Uri(url));
            _webRequest.Method = method;
            _webRequest.Timeout = 1000 * 30; //60 * 30;
            _webRequest.ContentType = "application/x-www-form-urlencoded";

            string result = null;
            byte[] byte_data = null;
            if (param != null && param.Trim().Length > 0) { 
                 byte_data = System.Text.Encoding.UTF8.GetBytes(param);
                 _webRequest.ContentLength = byte_data.Length;
            }
            try
            {
                if(byte_data != null && byte_data.Length > 0)
                {
                    using (Stream writeStream = _webRequest.GetRequestStream())
                    {
                        writeStream.Write(byte_data, 0, byte_data.Length);
                        using (HttpWebResponse response = (HttpWebResponse)_webRequest.GetResponse())
                        {
                            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                            {
                                result = sr.ReadToEnd();
                            }
                        }
                    }
                }
                else 
                {
                    using (HttpWebResponse response = (HttpWebResponse)_webRequest.GetResponse())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                        {
                            result = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                logger.Info(e.Message);
                result = "ERR:" + e.Message;
            }
            return result;
        }

        public string RequestURL(String url, string param) {
            return RequestURL(url, "POST", param);
        }
    }
}
