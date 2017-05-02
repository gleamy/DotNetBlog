using MTConnect.Clients;
using MTConnect.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTConnect
{
    public class ConsoleService
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ConsoleService));

        MTConnectClient client;

        public string AgentAddress
        {
            set;
            get;
        }

        public string MonitorAddress {
            set;
            get;
        }

        public void Start() {
            if (client != null)
                return;

            client = new MTConnectClient(AgentAddress, null);
            client.Error += Client_Error;
            //client.ProbeReceived += Client_ProbeReceived;

            // - 经过测试，只返回一次，不会轮询返回。
            client.CurrentReceived += Client_CurrentReceived;

            // - 只会返回建立连接之后变化过的数据，不断的轮询返回,  因此必须与 'CurrentReceived' 配合起来使用。
            client.SampleReceived += Client_CurrentReceived;

            //client.ProbeReceived += Client_ProbeReceived;

            //client.SampleReceived += StreamsSuccessful;
            client.Start();
        }

        private void Client_CurrentReceived(MTConnectStreams.Document document)
        {
            if (document == null || document.DeviceStreams == null || document.DeviceStreams.Count < 1)
                return;
            foreach (MTConnectStreams.DeviceStream ds in document.DeviceStreams)
            {
                // 通过对 Name 的调整（去掉 di,ev,sp, cd）进行验证后，发现 DataItems 中包含了 Event 、 Samples、Conditions
                // ComponentStreams 比较杂，好像什么都包含，就不在这里验证了。
                // 因此在这里只保留了对 DataItems 的读取。
                string namePrefix = ds.Uuid + ":" + ds.Name + ":";
                if (ds.DataItems != null && ds.DataItems.Count > 0)
                {
                    foreach (MTConnect.MTConnectStreams.DataItem di in ds.DataItems)
                    {
                        try
                        {
                            SimpleHttpHelper.GetInstance()
                                //.RequestURL("http://127.0.0.1:15031/monitor/data_pack/put",
                                //.RequestURL("http://192.168.123.248:15031/monitor/data_pack/put",
                                .RequestURL(MonitorAddress,
                                "p=" + ds.Name + "&n=" + di.Name +"&v=" + di.CDATA);
                        }
                        catch (Exception ex)
                        {
                            logger.Warn(ex.Message, ex);
                        }
                    }
                }
            }
        }

        private void Client_Error(MTConnectError.Document errorDocument)
        {
            logger.Error(errorDocument.ToString());
            
        }
    }
}
