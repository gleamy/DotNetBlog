using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args){
            var time =
            DateTime.Parse("2014-07-18 09:40:07.357014126");
            Console.WriteLine(time);
            //Console.WriteLine(
            //Environment.GetEnvironmentVariable("PATH"));

            Console.ReadLine();
            
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Program Files\Java\jre1.8.0_20\bin\java.exe";
            ps.Arguments = "-jar D:\\ssh2.test.jar showlist 192.168.134.132 root 123456 .";
            ps.RedirectStandardOutput = true;
            ps.UseShellExecute = false;
            ps.CreateNoWindow = true;
            Process p = new Process() { StartInfo = ps, EnableRaisingEvents = true };
            p.Exited += p_Exited;
            p.OutputDataReceived += p_OutputDataReceived;
            p.Start();
            p.BeginOutputReadLine();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ": main");
            //Console.WriteLine(p.StandardOutput.ReadToEnd());
            Console.ReadLine();
            Console.WriteLine("md");
            Console.ReadLine();
            //Console.WriteLine("process has exited - " + p.HasExited);
        }

        static void p_Exited(object sender, EventArgs e)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ": exited event..");
            Process p = sender as Process;
            if (p == null)
            {
                Console.WriteLine("process is null.");
            }
            else
            {
                Console.WriteLine("process has exited - " + p.HasExited);
            }
            p.Close();
            p.Dispose();
            Console.WriteLine(e.GetHashCode());
        }

        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ":" + e.Data);
        }
    }
}
