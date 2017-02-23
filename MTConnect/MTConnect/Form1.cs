using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTConnectDevices = MTConnect.MTConnectDevices;
using MTConnectStreams = MTConnect.MTConnectStreams;
using MTConnect.Clients;
using MTConnect.MTConnectError;
using System.Collections;

namespace MTConnect
{
    public partial class Form1 : Form
    {
        MTConnectClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (client != null)
                return;

            client = new MTConnectClient(txt_agent.Text, txt_driver.Text);
            client.Error += Client_Error;
            //client.ProbeReceived += Client_ProbeReceived;

            // - 经过测试，只返回一次，不会轮询返回。
            client.CurrentReceived += Client_CurrentReceived;

            // - 只会返回建立连接之后变化过的数据，不断的轮询返回,  因此必须与 'CurrentReceived' 配合起来使用。
            client.SampleReceived += Client_CurrentReceived;

            //client.SampleReceived += StreamsSuccessful;
            client.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (client == null)
                return;
            client.Stop();
            client = null;
        }

        private void Client_CurrentReceived(MTConnectStreams.Document document)
        {
            if (document == null || document.DeviceStreams == null || document.DeviceStreams.Count < 1)
                return;
            LinkedList<Poco> pocos = new LinkedList<Poco>();
            foreach (MTConnectStreams.DeviceStream ds in document.DeviceStreams)
            {
                // 通过对 Name 的调整（去掉 di,ev,sp, cd）进行验证后，发现 DataItems 中包含了 Event 、 Samples、Conditions
                // ComponentStreams 比较杂，好像什么都包含，就不在这样验证了。
                // 因此在这里只保留了对 DataItems 的读取。
                string namePrefix = ds.Uuid + ":" + ds.Name + ":";
                if (ds.DataItems != null && ds.DataItems.Count > 0)
                {
                    foreach (MTConnect.MTConnectStreams.DataItem di in ds.DataItems)
                    {
                        pocos.AddLast(new Poco()
                        {
                            Name = namePrefix + di.DataItemId + ":" + di.Name + "-"+di.Category+ "-di",
                            Timestamp = di.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"),
                            Value = di.CDATA
                        });

                        PushToMonitorService ptms = PushToMonitorService.getInstance();
                        if (ptms != null)
                        {
                            ptms.push(di.DataItemId + "_" + di.Name, di.Timestamp, di.CDATA);
                        }
                    }
                }

                // 经验证，这个节点特别像他的父节点，什么都包含。
                //if (ds.ComponentStreams != null && ds.ComponentStreams.Count > 0)
                //{
                //    foreach (MTConnect.MTConnectStreams.ComponentStream cs in ds.ComponentStreams)
                //    {
                //        pocos.AddLast(new Poco()
                //        {
                //            Name = namePrefix + cs.ComponentId + ":" + cs.Name + "-cs",
                //            Timestamp = cs.Samples .Timestamp.ToString("yyyy-MM-dd HH:mm:ss"),
                //            Value = di.CDATA
                //        });
                //    }
                //}

                //if (ds.Samples != null && ds.Samples.Count > 0)
                //{
                //    foreach (MTConnectStreams.Sample sp in ds.Samples)
                //    {
                //        pocos.AddLast(new Poco()
                //        {
                //            Name = namePrefix + sp.DataItemId + ":" + sp.Name + "-sp",
                //            Timestamp = sp.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"),
                //            Value = sp.CDATA
                //        });
                //    }
                //}

                //if (ds.Events != null && ds.Events.Count > 0)
                //{
                //    foreach (MTConnectStreams.Event ev in ds.Events)
                //    {
                //        pocos.AddLast(new Poco()
                //        {
                //            Name = namePrefix + ev.DataItemId + ":" + ev.Name + "-di",
                //            Timestamp = ev.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"),
                //            Value = ev.CDATA
                //        });
                //    }
                //}

                //if (ds.Conditions != null && ds.Conditions.Count > 0)
                //{
                //    foreach (MTConnect.MTConnectStreams.Condition di in ds.Conditions)
                //    {
                //        pocos.AddLast(new Poco()
                //        {
                //            Name = namePrefix + di.DataItemId + ":" + di.Name + "-cd",
                //            Timestamp = di.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"),
                //            Value = di.CDATA
                //        });
                //    }
                //}
            }
            putToLV(pocos.ToArray());
        }

        private void Client_Error(MTConnectError.Document errorDocument)
        {
            if (errorDocument == null || errorDocument.Errors == null || errorDocument.Errors.Count < 1)
                return;
            Poco[] pocos = new Poco[ errorDocument.Errors.Count];
            for (int i = 0; i < errorDocument.Errors.Count; i++)
            {
                pocos[i] = new Poco() {
                    Name = "err:" + errorDocument.Header + ":" + errorDocument.Errors[i].ErrorCode,
                    Timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Value = errorDocument.Errors[i].CDATA
                };

                PushToMonitorService ptms = PushToMonitorService.getInstance();
                if (ptms != null)
                {
                    ptms.push(errorDocument.Errors[i].ErrorCode.ToString(), DateTime.Now, errorDocument.Errors[i].CDATA);
                }
            }
            putToLV(pocos);
        }

        /// <summary>
        /// 向窗体上打印数据。
        /// </summary>
        /// <param name="pocos"></param>
        private void putToLV(Poco[] pocos) {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Poco[]>(putToLV), new object[] { pocos });
                return;
            }
            if (pocos == null || pocos.Length < 1)
                return;
            foreach (var item in pocos)
            {
                ListViewItem row = null;
                if (lv_content.Items.ContainsKey(item.Name))
                    row = lv_content.Items[item.Name];
                else
                {
                    row = lv_content.Items.Add(item.Name, (lv_content.Items.Count + 1).ToString("0000"), 0);
                    row.SubItems.Add("");
                    row.SubItems.Add("");
                    row.SubItems.Add("");
                }

                row.SubItems[1].Text = item.Name == null ? string.Empty : item.Name;
                row.SubItems[2].Text = item.Timestamp == null ? string.Empty : item.Timestamp;
                row.SubItems[3].Text = item.Value == null ? string.Empty : item.Value;
            }
        }

        private class Poco
        {
            public String Name { set; get; }
            public String Timestamp { set; get; }
            public String Value { set; get; }
        }


        class ListViewSort : IComparer
        {
            private int col;
            private bool descK;
            public ListViewSort()
            {
                col = 0;
            }
            public ListViewSort(int column, object Desc)
            {
                descK = (bool)Desc;
                col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递 
            }
            public int Compare(object x, object y)
            {
                var lx = x as ListViewItem;
                var ly = y as ListViewItem;
                var tx = lx.SubItems.Count > col ? lx.SubItems[col].Text : string.Empty;
                var ty = ly.SubItems.Count > col ? ly.SubItems[col].Text : string.Empty;

                int tempInt = String.Compare(tx, ty);
                if (descK) return -tempInt;
                else return tempInt;
            }
        }

        private void lv_content_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.Columns[e.Column].Tag == null)
                lv.Columns[e.Column].Tag = true;
            bool flag = (bool)lv.Columns[e.Column].Tag;
            if (flag)
                lv.Columns[e.Column].Tag = false;
            else
                lv.Columns[e.Column].Tag = true;
            lv.ListViewItemSorter = new ListViewSort(e.Column, lv.Columns[e.Column].Tag);
            lv.Sort();//对列表进行自定义排序  

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_stop_Click(null, null);
        }
    }
}
