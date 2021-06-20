using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace Medical
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); ;
            Dictionary<string, string> numbers = new Dictionary<string, string>(5);
            numbers.Add("timestamp", "20.07.2021 21:30:25");
            numbers.Add("diagnosis", "I21");
            numbers.Add("service1", "A09.05.009");
            numbers.Add("service2", "A09.05.037");
            //Dictionary<string> numbers = new Dictionary<string>() { DateTime : 20.07.2021 21:30:25, "I21", "À09.05.009", "À09.05.037" };
            Dictionary<string, string> codes = new Dictionary<string, string>(5);
            Dictionary<string, bool> repeater = new Dictionary<string, bool>(5);
            string date = numbers["timestamp"];
            string diagnoz = numbers["diagnosis"];
            numbers.Remove("timestamp");
            numbers.Remove("diagnosis");
            foreach (var key in numbers.Values)
            {

                foreach (var VARIABLE in codes.Values)
                {

                    if (key == VARIABLE)
                    {
                        repeater.Add(key, true);

                        break;
                    }

                }

            }


            
            

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
