using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace LONGO.CommonModule
{
    public class RealtimeFileCache
    {
        #region - Get instance . -

        private static System.Collections.Generic.Dictionary<string, RealtimeFileCache> 
            _instances = new Dictionary<string, RealtimeFileCache>();

        /// <summary> 构建 实时数据 文件式 缓存对象 </summary>
        /// <param name="name"> 
        /// - 正常情况下默认每项缓存的大小为 1024 * 5，即 5 KB. 
        /// - 但是如果名称为“XXXX_IS2048”形式时，每项缓存的大小为 1024 * 2，即 2 KB. </param>
        /// <returns></returns>
        public static RealtimeFileCache GetInstance(string name) 
        {
            if (!_instances.ContainsKey(name)) 
            {
                lock (typeof(RealtimeFileCache))
                {
                    if (!_instances.ContainsKey(name))
                    {
                        _instances[name] = new RealtimeFileCache(name);
                    }
                }
            }
            return _instances[name];
        }

        #endregion

        public readonly int ITEM_LENGTH = 1024 * 5;

        private string _name;
        private FileStream _fs = null;
        private Dictionary<string, long> _index = new Dictionary<string, long>();

        /// <summary> 初始化 </summary>
        /// <param name="name"></param>
        private RealtimeFileCache(string name) 
        {
            _name = name;

            // - ITEM SIZE
            int sizeIndex = name.LastIndexOf("_IS");
            if (sizeIndex != 0) {
                string strSize = name.Substring(sizeIndex + 3);
                int size = 0;
                if (int.TryParse(strSize, out size)) 
                {
                    ITEM_LENGTH = size;    
                }
            }

            String filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).Trim().TrimEnd('\\');
            filePath += "\\longo_mdc_cache";
            if (!System.IO.Directory.Exists(filePath))
                System.IO.Directory.CreateDirectory(filePath);
            filePath += "\\V01_" + name + ".cache";

            _fs = new System.IO.FileStream(filePath,
                FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None, 2048, false);
            int i = 0;
            while (_fs.Length > ITEM_LENGTH * i) 
            {
                _fs.Position = ITEM_LENGTH * i;
                int keylength = _fs.ReadByte();
                byte[] b = new byte[keylength];
                _fs.Read(b, 0, keylength);
                _index.Add(System.Text.Encoding.UTF8.GetString(b), ITEM_LENGTH * i);
                i++;
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Set(string key, string value) 
        {
            if (!_index.ContainsKey(key)) 
            {
                byte[] b = System.Text.Encoding.UTF8.GetBytes(key);
                _index[key]  = ITEM_LENGTH * _index.Count;
                _fs.Position = _index[key];
                _fs.WriteByte((byte)b.Length);
                _fs.Write(b, 0, b.Length);
                b = new byte[ITEM_LENGTH - 1 - b.Length];
                _fs.Write(b, 0, b.Length);
            }
            _fs.Position = _index[key];
            int key_length = 1 + _fs.ReadByte();
            _fs.Position = _index[key] + key_length;
            if (string.IsNullOrEmpty(value))
            {
                _fs.Write(BitConverter.GetBytes((UInt16)0), 0, 2);
            }
            else
            {
                byte[] bValue = System.Text.Encoding.UTF8.GetBytes(value);
                if (key_length + 2 + bValue.Length > ITEM_LENGTH) 
                {
                    throw new Exception("Real time file cache exceed length, - " + _name + " - " + key);
                }
                _fs.Write(BitConverter.GetBytes((UInt16)bValue.Length), 0, 2);
                _fs.Write(bValue, 0, bValue.Length);
            }
            _fs.Flush();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public string Get(string key) {
            if (!_index.ContainsKey(key))
                return null;
            _fs.Position = _index[key];
            _fs.Position = _fs.Position + 1 + _fs.ReadByte(); // 跳过键值
            byte[] b = new byte[2];
            _fs.Read(b, 0, 2);
            UInt16 length = BitConverter.ToUInt16(b, 0);
            if (length < 1)
                return string.Empty;
            b = new byte[length];
            _fs.Read(b, 0, length);
            return System.Text.Encoding.UTF8.GetString(b);
        }
    }
}
