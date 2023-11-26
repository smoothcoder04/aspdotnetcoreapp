using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using People;
using Data;

namespace mymvcapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Adding records to the database...");
            using (var db = new StudentDBContext())
            {
                // Add the following students to Database
                db.Students.AddRange(new Student { Name = "Wyatt", Grade = 95 },
                new Student { Name = "Kristen", Grade = 98 },
                new Student { Name = "Matt", Grade = 90 },
                new Student { Name = "Bill", Grade = 91 });

                // Save the changes
                db.SaveChanges();
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

