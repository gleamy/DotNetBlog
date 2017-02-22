using MTConnect.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTConnect
{
    class PushToMonitorService
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(PushToMonitorService));

        private static PushToMonitorService _instance;

        public static PushToMonitorService getInstance() {
            // - 命令参数不存在‘datatoservice’,不向本机的采集服务中推入数据。
            String[] args = Environment.GetCommandLineArgs();
            if (args == null) return null;
            if (!Array.Exists(args, a => a != null && a.ToLower() == "datatoservice"))
            {
                return null;
            }
            // - 暂时不做同步处理。
            if (_instance == null)
                _instance = new PushToMonitorService();
            return _instance;
        }

        private System.Timers.Timer timer = null; 

        private volatile bool hasChenge = false;

        private Dictionary<String, Poco> dataCache = new Dictionary<string, Poco>(3000); 

        /// <summary>
        /// 私有构造器，防止外部直接创建该对象。
        /// </summary>
        private PushToMonitorService()
        {
            timer = new System.Timers.Timer() { AutoReset = false, Interval = 500 };
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                // - 缓冲了信息的发送，可能会丢失部分变化频率比较高的数据， 但是保持住的数据不会丢失。
                // - 还有一个问题后续考虑，丢弃了原始的时间戳。
                while (hasChenge) {
                    hasChenge = false;
                    if (dataCache.Count < 1)
                        break;
                    foreach (var item in dataCache)
                    {
                        if (item.Value.Timestamp == item.Value.sendedTimestamp)
                            continue;
                        try
                        {
                            SimpleHttpHelper.GetInstance()
                                //.RequestURL("http://127.0.0.1:15031/monitor/data_pack/put",
                                .RequestURL("http://192.168.123.248:15031/monitor/data_pack/put",
                                "p=845244&n=" + item.Value.Name + "&v=" + item.Value.Value);
                            item.Value.sendedTimestamp = item.Value.Timestamp;
                        }
                        catch (Exception ex)
                        {
                            logger.Warn(ex.Message, ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
            }
            finally
            {
                timer.Start();
            }
        }

        public void push(String name, DateTime timestamp, String value)
        {
            if (!dataCache.ContainsKey(name))
            {
                lock (dataCache)
                {
                    if (!dataCache.ContainsKey(name))
                        dataCache.Add(name, new Poco());
                }
            }
            dataCache[name].Timestamp = timestamp;
            dataCache[name].Value = value;
            hasChenge = true;
        }

        private class Poco {

            public String Name { set; get; }

            public DateTime Timestamp { set; get; }

            public String Value { set; get; } 

            public DateTime sendedTimestamp { set; get; }
        }
    }
}
