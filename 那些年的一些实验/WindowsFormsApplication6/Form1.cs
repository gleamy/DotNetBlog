using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        Entity[] _entitys = new Entity[]{
                new Entity() { A = "A1", B = "B1" },
                new Entity() { A = "A2", B = "B2" },
                new Entity() { A = "A3", B = "B3" },
                new Entity() { A = "A4", B = "B3" }
            };

        DataGridViewExtend _gridViewExtend = null;
        public Form1()
        {
            InitializeComponent();

            _gridViewExtend = new DataGridViewExtend(dataGridView1);
        }

        public String Option { set; get; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var index = -1;
            _gridViewExtend.Clear();

            foreach (Entity ett in _entitys)
            {
                index = _gridViewExtend.SetItem(ett);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
            {
                var row = dataGridView1.Rows[e.RowIndex + i];
                var rowDi = row.DataBoundItem as Entity;

                if (rowDi == null)
                    return;

                if (rowDi.A == Option)
                {
                    row.Cells[col_CheckBox.Index].Value = true;
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }
    }
}
