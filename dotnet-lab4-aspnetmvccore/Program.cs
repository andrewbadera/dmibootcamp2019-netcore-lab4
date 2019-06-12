using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotnet_lab4_aspnetmvccore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDomain ad = AppDomain.CreateDomain("HelloWorld Domain");
            //TODO Replace this path with the path on your machine
            ad.ExecuteAssembly(@"C:\Users\abadera\source\repos\dotnetcore-lab4\dotnetcore-lab4-aspnetmvc\static\ConsoleApp1.exe");

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
