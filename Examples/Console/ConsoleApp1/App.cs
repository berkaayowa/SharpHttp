using SharpHttpServer.Attribute;
using SharpHttpServer.Controller;
using SharpHttpServer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class App : SharpHttpServerController 
    {
        public SharpHttpServerResult Help()
        {
            //returns text/string 
            return Text("In app->help function...");
        }

        public SharpHttpServerResult Version()
        {
            //retunrs json
            return Json("{\"version\":\"1.0.0\"}");
        }

        public SharpHttpServerResult Configuration()
        {
            //retunrs XML
            return XML("<Config><Version>1.0.0</Version><DateTime>"+DateTime.Now.ToString()+"</DateTime></Config>");
        }

        //Post Only fuction
        //this function will only be availabel on post request
        [RouteSharpHttp(SharpHttpMethod.POST)]
        public SharpHttpServerResult Command()
        {
            return Text("In app->Command function...");
        }
    }
}
