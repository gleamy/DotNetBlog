using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(a);

            Console.WriteLine(t.FullName);

            object o =
            t.Assembly.CreateInstance(t.FullName + "+b");

            Console.WriteLine(o.GetType().FullName);

            Console.ReadKey();
        }
    }

    public abstract class a
    {
        internal class b : a
        { 
        
        }
    }
}
