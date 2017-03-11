using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Temp_3();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary> Niles LT4 </summary>
        static void Temp_3()
        {
            int id = 800;
            using (StreamReader sr = new StreamReader(
                new FileStream(@"G:\客户资料\北京_博士力士乐二厂（采埃孚）\需求整理\报警信息需求\NIlesLT4.044", FileMode.Open, FileAccess.Read), Encoding.ASCII))
            {
                using (StreamWriter sw = new StreamWriter(
                    new FileStream(@"G:\客户资料\北京_博士力士乐二厂（采埃孚）\需求整理\报警信息需求\NIlesLT4.044.pdc", FileMode.Create, FileAccess.Write), Encoding.ASCII))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine().Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        string alamCode = Regex.Match(line, @"\d{4}").Value;
                        string alamInfo = line.Substring(7).Replace("\t", string.Empty).Replace(" ", string.Empty).Replace("&", "-").TrimEnd(')');
                        sw.WriteLine("Insert into LB_ALAR_TEMP(ID, SORT_ID, ALAR_CODE, ALAR_INFO) "
                            + "Values(" + id++ + ", 3, '" + alamCode + "', '" + alamInfo.Replace("\'", "''") + "');");
                    }
                }
            }

        }


        /// <summary> DS </summary>
        static void Temp_2()
        {
            int id = 300;
            using (StreamReader sr = new StreamReader(
                new FileStream(@"G:\客户资料\北京_博士力士乐二厂（采埃孚）\DS报警.044", FileMode.Open, FileAccess.Read), Encoding.ASCII))
            {
                using (StreamWriter sw = new StreamWriter(
                    new FileStream(@"G:\客户资料\北京_博士力士乐二厂（采埃孚）\DS报警.044.pdc", FileMode.Create, FileAccess.Write), Encoding.ASCII))
                {

                    while (!sr.EndOfStream)
                    {
                        id++;
                        string line = sr.ReadLine().Trim();

                        string alamCode = Regex.Match(line, @"\d{6}").Value;
                        string alamInfo = line.Substring(22).Replace("\t", string.Empty).Replace("&", "-").TrimEnd(')');
                        sw.WriteLine("Insert into LB_ALAR_TEMP(ID, SORT_ID, ALAR_CODE, ALAR_INFO) "
                            + "Values(" + id + ", 2, '" + alamCode + "', '" + alamInfo.Replace("\'", "''") + "');");
                    }
                }
            }

        }


        /// <summary>
        /// PAMA
        /// </summary>
        static void Temp_1() 
        {
            int id = 1;
            using (StreamReader sr = new StreamReader(
                new FileStream(@"G:\客户资料\北京_博士力士乐二厂（采埃孚）\PAMA 报警.txt", FileMode.Open, FileAccess.Read), Encoding.ASCII))
            {
                using (StreamWriter sw = new StreamWriter(
                    new FileStream(@"G:\客户资料\北京_博士力士乐二厂（采埃孚）\PAMA 报警.sql", FileMode.OpenOrCreate, FileAccess.Write), Encoding.ASCII))
                {

                    while (!sr.EndOfStream)
                    {
                        id++;
                        string line = sr.ReadLine().Trim();
                        
                        string alamCode = Regex.Match(line, @"\d{6}").Value;
                        string alamInfo = line.Substring(24).Replace("\t", string.Empty).TrimEnd(')');
                        sw.WriteLine("Insert into LB_ALAR_TEMP(ID, SORT_ID, ALAR_CODE, ALAR_INFO) "
                            + "Values(" + id + ", 1, '" + alamCode + "', '" + alamInfo.Replace("\'", "''") + "');");
                    }
                }
            }

        }
    }
}
