using SharpHttpServer.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("########################################");
            Console.WriteLine("##### Welocme to this console app ######");
            Console.WriteLine("########################################");
            Console.WriteLine("#    This console app has Http Server  #");
            Console.WriteLine("########################################");


            //Set up Log envent
            SharpHttp.Server.OnEvent += Log;

            //Setup & run the Server 
            SharpHttp.Server.Run("http://localhost:8091/", typeof(Program)).AlwaysOn();
        }

        //This sis basic log function 
        //We are just writing logs on console
        static void Log(SharpHttpLogSource source, SharpHttpLogType logType, object obj)
        {
            //Console.Clear();
            Console.WriteLine(DateTime.Now.ToString() + "-" + obj.ToString());
            
        }
    }
}
