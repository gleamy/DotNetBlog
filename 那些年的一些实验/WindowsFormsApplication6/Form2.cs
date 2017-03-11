using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        Form1 _form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form1.Option = textBox1.Text;
            _form1.ShowDialog(this);
            //new Form1().ShowDialog(this);
        }
    }
}
