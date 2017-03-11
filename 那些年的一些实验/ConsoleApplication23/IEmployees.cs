using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ConsoleApplication23
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IIEmployees”。
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface IEmployees
    {
        [WebGet(UriTemplate = "all", ResponseFormat = WebMessageFormat.Json)]
        [Description("获取所有员工列表")]
        IEnumerable<Employee> GetAll();

        [WebGet(UriTemplate = "{id}/{number}", ResponseFormat = WebMessageFormat.Json)]
        [Description("获取指定ID的员工")]
        Employee Get(string id, string number);

        //[WebInvoke(UriTemplate = "/", Method = "POST")]
        //[Description("创建一个新的员工")]
        //Employee Create(Employee employee);

        //[WebInvoke(UriTemplate = "/", Method = "PUT")]
        //[Description("修改现有员工信息")]
        //void Update(Employee employee);

        //[WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        //[Description("删除指定ID的员工")]
        //void Delete(string id);
    }
}
