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
        //Method Get
        //http://localhost:8091/app/help
        public SharpHttpServerResult Help()
        {
            //returns text/string 
            return Text("In app->help function...");
        }

        //Method Get
        //http://localhost:8091/app/version
        public SharpHttpServerResult Version()
        {
            //retunrs json
            return Json("{\"version\":\"1.0.0\"}");
        }

        //Method Get
        //http://localhost:8091/app/configuration
        public SharpHttpServerResult Configuration()
        {
            //retunrs XML
            return XML("<Config><Version>1.0.0</Version><DateTime>"+DateTime.Now.ToString()+"</DateTime></Config>");
        }

        //This function will only be available on post request
        //Method Post
        //http://localhost:8091/app/command
        [RouteSharpHttp(SharpHttpMethod.POST)]
        public SharpHttpServerResult Command()
        {
            return Text("In app->Command function...");
        }
    }
}
