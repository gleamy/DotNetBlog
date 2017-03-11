using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<abc> ld = new List<abc>();
            ld.Add(new abc() { d = 0.001 });
            ld.Add(new abc() { d = 5.11 });
            ld.Add(new abc() { d = 0.01 });
            ld.Add(new abc() { d = 0.01 });
            ld.Add(new abc() { d = 22.2 });
            ld.Add(new abc() { d = 1.2 });
            ld.Add(new abc() { d = 11.1 });
            ld.Add(new abc() { d = 12.0019 });
            ld.Add(new abc() { d = 0.001 });
            ld.Add(new abc() { d = 0.001 });
            ld.Add(new abc() { d = 0.001 });
            ld.Sort((a, b) => b.d > a.d ? 1 : -1);
        }

        
    }
    public class abc {
        public Double d
        {
            set;
            get;
        }

        public override string ToString()
        {
            return d.ToString();
        }
    }
}
