using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
          A.GetInstance().
        }
    }

    public abstract class A
    {
        private static A _instance = null;

        public static A GetInstance()
        {
            if (_instance == null)
            {
                lock (typeof(A))
                {
                    if (_instance == null)
                    {
                        _instance = new A_();
                    }
                }
            }
            return _instance;
        }


        class A_ : A { }
    }
}
