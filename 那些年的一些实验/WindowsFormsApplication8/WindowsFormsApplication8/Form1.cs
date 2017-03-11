using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        private List<string> dataBuffer = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog(this);
            Encoding encoding = Encoding.ASCII;
            if (cb_Encoding.Text.Trim() != String.Empty) 
            {
                encoding = Encoding.GetEncoding(cb_Encoding.Text.Trim());
            }

            if (ofd.FileName == null || ofd.FileName.Trim() == string.Empty)
                return;


            dataBuffer.Clear();

            SetColumn(new string[] {"row"}); 
            using (StreamReader sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read), encoding)) {
                while (!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    dataBuffer.Add(line);
                    AddItem(new string[] { sr.ReadLine() });
                }
            }
        }

        private void SetColumn(string[] colNames) 
        { 
            if(colNames == null && colNames.Length < 1)
                return;
            listView1.Clear();
            listView1.Columns.Clear();
            for (int i = 0; i < colNames.Length; i++)
            {
                listView1.Columns.Add(colNames[i]);    
            }
        }

        private void AddItem(string[] item) 
        {
            listView1.Items.Add(new ListViewItem(item));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetColumn(new string[] { "AlarmCode", "Sort_1", "Sort_2", "AlarmInfo", "Original value" });
            foreach (var data in dataBuffer)
            {
                string[] item = new string[] { "", "", "", "", "" };

                item[0] = ParseData(cb_AlarmCode.Text, data);
                item[1] = ParseData(cb_Sort_1.Text, data);
                item[2] = ParseData(cb_Sort_2.Text, data);
                item[3] = ParseData(cb_AlarmInfo.Text, data);
                item[4] = data;
                AddItem(item);
            }
            //System.Text.RegularExpressions.Regex.Match()
        }

        private string ParseData(string condition, string data) 
        {
            if (string.IsNullOrEmpty(condition) || string.IsNullOrEmpty(data))
                return string.Empty;

            string c = condition.Trim();
            //"RANG: <start index>-<length/none>",
            //"SEPA: <Separator>[-SP-]<index>",
            //"REGE: <Regexp>"});
            if (c.StartsWith("RANG:")) 
            { 
                c = c.Substring(5).Trim();
                string[] value = c.Split('-');
                if (value.Length > 1 && value[1].Trim() != string.Empty) 
                { 
                    return data.Substring(int.Parse(value[0]), int.Parse(value[2]));
                }
                else
                {
                    return data.Substring(int.Parse((value[0])));
                }
            }
            else if (c.StartsWith("SEPA:"))
            {
                c = c.Substring(5).Trim();
                string[] value = c.Split(new string[]{"[-SP-]"},  StringSplitOptions.RemoveEmptyEntries);
                if (value.Length > 1 && value[1].Trim() != string.Empty) 
                { 
                    return data.Split(new string[]{value[0]},StringSplitOptions.None)[int.Parse(value[1].Trim())];
                }
                else
                {
                    return data.Split(new string[]{value[0]},StringSplitOptions.None)[0];
                }
            }
            else if(c.StartsWith("REGE:")) 
            {
                c = c.Substring(5).Trim();
                return Regex.Match(data, c).Value;
            }
            
            return string.Empty;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
