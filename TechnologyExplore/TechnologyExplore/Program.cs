using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TechnologyExplore
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().test();
        }

        public void test() {
            Task<String> t = Task.Factory.StartNew<String>(delegate(){
                Thread.Sleep(1000); return "aaaaa"; });
            //t.Start(); 
            // 调用Start 会发生如下的异常， 可见 StartNew 会直接启动任务；
            // 未处理System.InvalidOperationException HResult=-2146233079 Message=不能对已开始的任务调用 Start。
            t.Wait();
            String st = t.Result;
            Console.WriteLine(st);

            Console.Read();
        }

        
    }
}
