using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main__(string[] args)
        {
            Console.WriteLine(IPAddress.Any.ToString());
            Console.ReadKey();
        }

        //static void HttpServerMain(string[] args)
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Employees));

            host.Open();
            Console.ReadKey();
            host.Close();
        }

        static void Main1111(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalculatorService));
            host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://localhost:8733/Design_Time_Addresses/WcfService/Service1/");
            if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            {
                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                behavior.HttpGetEnabled = true;
                behavior.HttpGetUrl = new Uri("http://localhost:8733/Design_Time_Addresses/WcfService/Service1/wsdl");
                host.Description.Behaviors.Add(behavior);
            }

            host.Open();

            Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");

            Console.Read();
            host.Close();
        }

        static void Main33(string[] args) 
        {
            // 创建一个独立AppDomain作为服务端。  
            AppDomain.CreateDomain("Server1").DoCallBack(delegate
            {
                ServiceHost host = new ServiceHost(typeof(Service1));
                host.AddServiceEndpoint(typeof(IService1),                  //契约(C)  
                                        new BasicHttpBinding(),             //绑定(B)  
                                        "http://localhost:9999/myservice"); //地址(A)  
                host.Open();
            });

            // 下面是客户端  
            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(
                new BasicHttpBinding(),
                "http://localhost:9999/myservice");
            IService1 client = factory.CreateChannel();
            var reply = client.SendMessage("Hello WCF");
            Console.WriteLine(reply);
            Console.Read(); 
            
        }

        static void Main22(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MDC_Server));
            host.AddServiceEndpoint(typeof(IMDC_Server), 
                new WSHttpBinding(), "http://localhost:8733/MDC_Server/");

            //ServiceHost host = new ServiceHost(typeof(Service1));
            //host.AddServiceEndpoint(typeof(IService1),                  //契约(C)  
            //                        new BasicHttpBinding(),             //绑定(B)  
            //                        "http://localhost:9999/myservice"); //地址(A)  
            host.Open();  

            //var behavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            //if (behavior == null)
            //{
            //    behavior = new ServiceMetadataBehavior();
            //    behavior.HttpGetEnabled = true;
            //    behavior.HttpGetUrl = new Uri("http://localhost:8733/MDC_Server/wsdl");
            //    host.Description.Behaviors.Add(behavior);
            //}
            //else
            //{
            //    //behavior.HttpGetEnabled = false;
            //}

            host.Open();

            Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");

            Console.Read();
            host.Close();
        }
    }
}
