using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication30
{
    class Program
    {

        static string str = 
@"longo_data_pack_lib/commons-pool-1.6.jar longo_data_pack
 _lib/jetty-io-8.1.8.v20121106.jar longo_data_pack_lib/jetty-util-8.1.
 8.v20121106.jar longo_data_pack_lib/jetty-webapp-8.1.8.v20121106.jar 
 longo_data_pack_lib/jetty-xml-8.1.8.v20121106.jar longo_data_pack_lib
 /jetty-server-8.1.8.v20121106.jar longo_data_pack_lib/javax.servlet-3
 .0.0.v201112011016.jar longo_data_pack_lib/jetty-continuation-8.1.8.v
 20121106.jar longo_data_pack_lib/jetty-http-8.1.8.v20121106.jar longo
 _data_pack_lib/jetty-servlet-8.1.8.v20121106.jar longo_data_pack_lib/
 jetty-security-8.1.8.v20121106.jar longo_data_pack_lib/gson-2.3.1.jar
  longo_data_pack_lib/spring-context-4.1.4.RELEASE.jar longo_data_pack
 _lib/spring-aop-4.1.4.RELEASE.jar longo_data_pack_lib/aopalliance-1.0
 .jar longo_data_pack_lib/spring-beans-4.1.4.RELEASE.jar longo_data_pa
 ck_lib/spring-core-4.1.4.RELEASE.jar longo_data_pack_lib/commons-logg
 ing-1.2.jar longo_data_pack_lib/spring-expression-4.1.4.RELEASE.jar l
 ongo_data_pack_lib/spring-jms-4.1.6.RELEASE.jar longo_data_pack_lib/s
 pring-messaging-4.1.6.RELEASE.jar longo_data_pack_lib/spring-tx-4.1.6
 .RELEASE.jar longo_data_pack_lib/spring-test-4.1.4.RELEASE.jar longo_
 data_pack_lib/spring-web-4.1.4.RELEASE.jar longo_data_pack_lib/spring
 -webmvc-4.1.4.RELEASE.jar longo_data_pack_lib/spring-context-support-
 4.1.4.RELEASE.jar longo_data_pack_lib/jsr250-api-1.0.jar longo_data_p
 ack_lib/activemq-all-5.11.0.jar longo_data_pack_lib/fastjson-1.2.4.ja
 r longo_data_pack_lib/common-util-4.1.1.jar longo_data_pack_lib/hk2-c
 ore-2.4.0-b31.jar longo_data_pack_lib/hk2-locator-2.4.0-b31.jar longo
 _data_pack_lib/javax.inject-2.4.0-b31.jar longo_data_pack_lib/aopalli
 ance-repackaged-2.4.0-b31.jar longo_data_pack_lib/hk2-api-2.4.0-b31.j
 ar longo_data_pack_lib/javassist-3.18.1-GA.jar longo_data_pack_lib/hk
 2-utils-2.4.0-b31.jar longo_data_pack_lib/javax.inject-1.jar longo_da
 ta_pack_lib/glassfish-api-4.1.1.jar longo_data_pack_lib/scattered-arc
 hive-api-4.1.1.jar longo_data_pack_lib/hk2-2.4.0-b31.jar longo_data_p
 ack_lib/config-types-2.4.0-b31.jar longo_data_pack_lib/hk2-config-2.4
 .0-b31.jar longo_data_pack_lib/tiger-types-1.4.jar longo_data_pack_li
 b/bean-validator-2.4.0-b31.jar longo_data_pack_lib/hk2-runlevel-2.4.0
 -b31.jar longo_data_pack_lib/class-model-2.4.0-b31.jar longo_data_pac
 k_lib/asm-all-repackaged-2.4.0-b31.jar longo_data_pack_lib/nucleus-gr
 izzly-all-4.1.1.jar longo_data_pack_lib/grizzly-framework-2.3.23.jar 
 longo_data_pack_lib/grizzly-portunif-2.3.23.jar longo_data_pack_lib/g
 rizzly-http-2.3.23.jar longo_data_pack_lib/grizzly-http-server-2.3.23
 .jar longo_data_pack_lib/grizzly-config-4.1.1.jar longo_data_pack_lib
 /management-api-3.2.1-b002.jar longo_data_pack_lib/log4j-1.2.17.jar l
 ongo_data_pack_lib/commons-fileupload-1.3.1.jar longo_data_pack_lib/c
 ommons-io-2.2.jar longo_data_pack_lib/javax.el-api-2.2.4.jar
";

        static void Main(string[] args)
        {
            var a =
              Int64.Parse("41247AE1", System.Globalization.NumberStyles.HexNumber);

              Console.WriteLine(a);
            str = str.Replace("\r\n ", "");
            str = str.Replace(' ', ';');
            str = str.Replace("longo_data_pack_lib/", "%SVC_HOME%\\longo_data_pack_lib\\");
            string ss = str.Length.ToString();


            

            var v =
            new System.Data.DataTable().Compute(
            
            "SubString('20.1' ,1,2)"
            //"CONVERT(String, 10, 112)"
            ,null);
            Console.WriteLine(v);
        }
    }
}
