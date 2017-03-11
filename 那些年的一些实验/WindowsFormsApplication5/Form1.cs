using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt
                = new ExcelHelper()
                .ImportExcelFile(@"E:\客户资料\秦皇岛_凯斯曼\客户提供资料\2015年1月生产计划-输入V2.xlsx");
        }
    }
}
