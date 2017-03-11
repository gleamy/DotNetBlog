using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        private Stream _stream = null;
        private uint countNumber = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //DateTime timeHour = new DateTime(2016, 6, 23, 8, 0, 0);

            //using (Stream st = File.Open("", FileMode.Open, FileAccess.Read))
            //{ 
            //    byte[] b = new byte[1024];
            //    st.Read(b, 0, 2);

            //    // - 版本号
            //    BitConverter.ToUInt16(b, 0);

            //    // - 数量
            //    st.Read(b, 0, 4);
            //    BitConverter.ToUInt32(b, 0);

            //    while (true)
            //    {
            //        // - 设备ID
            //        long l = 0;
            //        if (st.Read(b, 0, 8) != 8) break;
            //        l = BitConverter.ToInt64(b, 0);

            //        // - 时间戳
            //        DateTime time = timeHour;
            //        if (st.Read(b, 0, 2) != 2) break;
            //        uint tempspan = BitConverter.ToUInt16(b, 0);
            //        time = time.AddSeconds(tempspan);


            //    }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] 
                data_item = { "AB", "BC", "DE", "ABC.--", "ABLLSIE", "AXXXAO", "123554", "XXX", "XXXAU", "45XXFX", "XX_JB" };
            long[] 
                equi_id = { 1, 45, 88, 65, 42, 77, 66, 33, 87 };
            string
                value = ";qeromiverh%^&%*^%k制造ma;zz中和来了33z5555555555555lsdvjajf524()*&&*&^84\n afa l"
                      + "life419681\r \t jiwefq;;z中黄;iweff^&^%%^*ijjxllllxiefjozpp\" ef"
                      + "jiefjeijjjadfapieij吧咯小，促进我fjaxooeofjmjo;iz;;;efjijx;&^^%%%^*^*^%";


            Random r = new Random();

            _stream = new FileStream("d:\\2016062413.datapackage", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _stream.Write(new byte[] { 0, 0 }, 0, 2);
            _stream.Write(new byte[] { 0, 0, 0, 0 }, 0, 4);
            _stream.Write(Encoding.ASCII.GetBytes("16062413"), 0, 8);

            DateTime b_time = new DateTime(2016, 6, 24, 13, 0, 0);
            DateTime e_time = new DateTime(2016, 6, 24, 14, 0, 0);
            while (b_time < e_time)
            {
                int number = r.Next(0, 100);
                for (int i = 0; i < number; i++) 
                {
                    long   eid = equi_id[r.Next(0, equi_id.Length)];
                    string name = data_item[r.Next(0, data_item.Length)];
                    int b_index = r.Next(0, value.Length);
                    int e_index = b_index == value.Length - 1 ? value.Length - 1 : r.Next(b_index, value.Length);
                    string v = b_index == e_index ? string.Empty : value.Substring(b_index, e_index - b_index);
                    PutData(b_time, eid, name, v);
                }
                b_time = b_time.AddSeconds(1);
            }

            _stream.Flush();
            _stream.Close();
        }

        private void PutData(DateTime time, long equi_id, string name, string value) {
            // - 写入数量
            _stream.Position = 2;
            _stream.Write(BitConverter.GetBytes(countNumber), 0, 4);
            _stream.Position = _stream.Length;

            _stream.Write(BitConverter.GetBytes(equi_id), 0, 8);
            _stream.Write(BitConverter.GetBytes((ushort)(time.Minute * 60 + time.Second)), 0, 2);
            
            byte[] data = Encoding.UTF8.GetBytes( name + " " + value);
            _stream.Write(BitConverter.GetBytes((ushort)data.Length), 0, 2);
            _stream.Write(data, 0, data.Length);
        }
    }
}
