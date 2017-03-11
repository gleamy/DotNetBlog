using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConsoleApplication23
{
    [ServiceContract]
    public interface IMDC_Server
    {
        [OperationContract]
        void InputData(string json);

        [OperationContract]
        string GetData();
    }
}
