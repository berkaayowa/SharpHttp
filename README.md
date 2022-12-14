# SharpHttpServer Library
### SharpHttpServer is a lightweight C# Library written by Berka Ayowa that helps you create a standalone HTTP server for your console or windows apps

>Latest version 1.0.0

To use the library, just  add the SharpHttpServer.dll reference to your c# console or windows project, they are located under the Library folder
>##We recommend installing the latest library version 1.0.0 from Nuget, searching SharpHttpServer from NuGet, and installing.
>Nuget Link https://www.nuget.org/packages/SharpHttpServer

### File name: Program.cs
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
            SharpHttp.Server.Run("http://localhost:8091/", typeof(Program))
            //Only call the function AlwaysOn() if this library is being used in a console app project'
            .AlwaysOn();
        }

        //This is a basic log function 
        //We are just writing logs on the console
        static void Log(SharpHttpLogSource source, SharpHttpLogType logType, object obj)
        {
            //Console.Clear();
            Console.WriteLine(DateTime.Now.ToString() + "-" + obj.ToString());
            
        }
    }
}

```
## Example of a controller class & methods
### File name: App.cs
```html
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


```

#### Events
| Name | Description | Example | 
| --- | --- | --- |
| OnEvent | This event for logging pursises| SharpHttp.Server.OnEvent += Log;

#### Action
| Name | Description | Example | 
| --- | --- | --- |
| Run | This action creates & starts running the HTTP server| SharpHttp.Server.Run("http://localhost:8091/", typeof(Program));
| AlwaysOn | This action is used to keep the HTTP server alive in the console app | SharpHttp.Server.Run("http://localhost:8091/", typeof(Program)).AlwaysOn();

>## Sample project can be found in Example folder

>Click [here](https://www.paypal.com/donate/?hosted_button_id=3EUXREY22UMGQ) to donate for supporting us to keep improving this library  
