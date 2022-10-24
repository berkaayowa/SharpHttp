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
    public class AppController : SharpHttpServerController 
    {
        public SharpHttpServerResult Help()
        {
            return Text("In app->help function...");
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
