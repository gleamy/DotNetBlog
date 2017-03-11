using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ConsoleApplication23
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SendMessage(string clientInput);
    }
    public class Service1 : IService1
    {
        #region IService1 Members
        public string SendMessage(string clientInput)
        {
            return string.Format("Server Get Message: {0}", clientInput);
        }
        #endregion
    }  
}
