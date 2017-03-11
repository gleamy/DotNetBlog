using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> d = new List<double>(null);
            double[] db = new double[3600];
            for (int i = 0; i < db.Length; i++ )
            {
                db[i] = i * 1.333333;
            }

            var b = Zip(db);

            object o = UZip(b);

            Console.WriteLine(o.ToString());

            //Console.WriteLine("str_1 : " + str_1);
            //var bt_1 = System.Text.Encoding.UTF8.GetBytes(str_1);
            //Console.WriteLine("bt_1 lenth : " + bt_1.Length);
            //var bt_2 = Zip(bt_1);
            //Console.WriteLine("bt_2 lenth : " + bt_2.Length);
            //var bt_3 = UZip(bt_2);
            //Console.WriteLine("bt_3 lenth : " + bt_3.Length);
            //String str_2 = System.Text.Encoding.UTF8.GetString(bt_3);
            //Console.WriteLine("str_2 : " + str_2);

            //Console.ReadKey();
        }

        const int GZIP_SIGN = 876496632;

        static byte[] 
            Zip(object data)
        {
            var innerdata = data as double[];
            if (innerdata == null)
                return null;

            byte[] rst_1 = null;
            using(MemoryStream ms = new MemoryStream())
            {
                for (int i = 0; i < innerdata.Length; i++)
                {
                    ms.Write(BitConverter.GetBytes(innerdata[i]), 0, 8);
                }
                rst_1 = ms.ToArray();
            }

            byte[] rst_2 = null;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(BitConverter.GetBytes(GZIP_SIGN), 0, 4);
                var zp = new GZipStream(ms, CompressionMode.Compress);
                zp.Write(rst_1, 0, rst_1.Length);
                zp.Close();
                rst_2 = ms.ToArray();
            }

            if (rst_2.Length >= rst_1.Length)
                return rst_1;
            else
                return rst_2;
        }

        static object 
            UZip(byte[] data)
        {
            byte[] box = null;
            if (GZIP_SIGN == BitConverter.ToInt32(data, 0))
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    ms.Position = 4;
                    byte[] buffer = new byte[1024];
                    var zp = new GZipStream(ms, CompressionMode.Decompress);
                    using (MemoryStream msout = new MemoryStream())
                    {
                        while (true)
                        {
                            var count = zp.Read(buffer, 0, buffer.Length);
                            if (count != 0)
                            {
                                msout.Write(buffer, 0, count);
                            }
                            if (count != buffer.Length)
                            {
                                break;
                            }
                        }
                        zp.Close();
                        box = msout.ToArray();
                    }
                }
            }
            else
            {
                box = data;
            }

            double[] rst = new double[box.Length / 8];
            for (int i = 0; i < rst.Length; i++)
            {
                rst[i] = BitConverter.ToDouble(box, 8 * i);
            }
            return rst;
        }
    }
}
