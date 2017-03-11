using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            IODBPMC0 o = new IODBPMC0();


            Console.WriteLine(o.ToString());
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public class IODBPMC0
    {
        [FieldOffset(0)]
        public short type_a;    /* PMC address type */
        [FieldOffset(2)]
        public short type_d;    /* PMC data type */
        [FieldOffset(4)]
        public short datano_s;  /* start PMC address */
        [FieldOffset(6)]
        public short datano_e;  /* end PMC address */
        [FieldOffset(8),
        MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] cdata;       /* PMC data */
    } /* In case that the number of data is 5 */
}
