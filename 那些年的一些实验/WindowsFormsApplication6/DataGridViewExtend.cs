using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public class DataGridViewExtend
    {
        private DataGridView _dataGridView = null;
        //ArrayList _list = new ArrayList();
        private BindingSource _dataSource = null;
        //private System.Collections.ArrayList list = new System.Collections.ArrayList();

        public DataGridViewExtend(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _dataGridView.AutoGenerateColumns = false;
            //_dataGridView.DataSource = _list;
            _dataSource = _dataGridView.DataSource as BindingSource;
        }

        public virtual int SetItem(Object o)
        {
            //var row = new DataGridViewRow();
            
            //_dataGridView.Rows.s
            //_list.Add(o);
            //_dataGridView
            //_dataGridView.
            //_dataGridVie
            //if (_dataSource.DataSource == null)
            //    _dataSource.DataSource = o.GetType();
            //var index = list.Add(o);
            //_dataGridView.r
            return _dataSource.Add(o);
        }

        public virtual void Clear()
        {

            //_dataGridView.Rows.Clear();
            _dataSource.Clear();
            //_dataGridView.DataSource = _dataSource = new BindingSource();
            
            //_dataSource.ResetBindings(true);
            //while (_dataSource.Count > 0)
            //{
            //    _dataSource.List.RemoveAt(0);
            //}
        }
    }
}
