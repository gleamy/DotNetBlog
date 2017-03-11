using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ConsoleApplication23
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“IEmployees”。
    public class Employees : IEmployees
    {
        int i = 1;

        public IEnumerable<Employee> GetAll()
        {
            ABC a = new ABC() 
            { A = "aaa", B = "ABC", C = "AAA" };

            return new Employee[] { 
                new Employee() { Name = "王文明", Age = i++, Aaa = a },
                new Employee(){ Name = "王鹏", Age = i++, Aaa = a }
            };
        }

        public Employee Get(string id, string number)
        {
            return new Employee() { Name = id + "/" + number, Age = 100 };
        }
    }
}
