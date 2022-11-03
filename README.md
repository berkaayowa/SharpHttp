# SharpHttpServer Library
### SharpHttpServer is a lightweight C# Library written by Berka Ayowa that helps you create, embed standalone Http server for console or windows apps

>Latest version 1.0.0

To use the library, just  add the SharpHttpServer.dll reference to you c# console or windows project, they are located under Library folder
>##We recommend installing the latest library version 1.0.0 from Nuget, search SharpHttpServer from nuget and install.
>Nuget Link https://www.nuget.org/packages/SharpHttpServer


```html
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

```

#### Events
| Name | Description | Example | 
| --- | --- | --- |
| OnEvent | This event for logging pursises| SharpHttp.Server.OnEvent += Log;

#### Action
| Name | Description | Example | 
| --- | --- | --- |
| Run | This action creates & starts runing the http server| SharpHttp.Server.Run("http://localhost:8091/", typeof(Program));
| AlwaysOn | This action cis used to keep the http server alive in console app | SharpHttp.Server.Run("http://localhost:8091/", typeof(Program)).AlwaysOn();

>#### Sample project can be found in Example folder

>Click [here](https://www.paypal.com/donate/?hosted_button_id=3EUXREY22UMGQ) to donate for supporting us to keep improving this library  
