using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new LPS.DTO.Model.Lps_MaterialDictionary[10];
            for (int i = 0; i < 10; i++)
            {
                v[i] = new LPS.DTO.Model.Lps_MaterialDictionary();
            }
            Console.WriteLine(v.Length);

            //var o =
            ////(LPS.DTO.Model.Lps_MaterialDictionary[])
            //new InternalClt().InvokeBLL("LPS.BLL.BLL_MaterialDictionary", "GetMaterialDictionaryAll", null);

            var o =
                //(LPS.DTO.Model.Lps_MaterialDictionary[])
            new InternalClt().InvokeBLL("LPS.BLL.BLL_MaterialDictionary", "GetMaterialDictByModel", new object[] { "1.6M" });

            Console.WriteLine(o);

            Console.ReadKey();
        }
    }
}
