using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace NextGenConfig.data
{
    public class Program
    {


        //    public class Program
        //    {
        //        public static void Main(string[] args)
        //             => CreateWebHostBuilder(args).Build().Run();
        //       // public static IHostBuilder CreateHostBuilder(string[] args)
        //       //=> Host.CreateDefaultBuilder(args)
        //       //    .ConfigureWebHostDefaults(
        //       //        webBuilder => webBuilder.UseStartup<Startup>());

        //        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //            WebHost.CreateDefaultBuilder(args)
        //                .UseStartup<Startup>();
        //    }
        //}

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }


        //    public static IWebHost BuildWebHost(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //    .UseStartup<Startup>()
        //    .ConfigureAppConfiguration((hostContext, config) =>
        //    {
        //        // delete all default configuration providers
        //        config.Sources.Clear();
        //        config.AddJsonFile("appsettings.json", optional: true);
        //    })
        //    .Build();
        //}
            public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>()
                    .Build();
        }
    }
