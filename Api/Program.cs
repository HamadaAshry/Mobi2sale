using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.IdentityUsers;
//using Domain.IdentityUsers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Api {
    public class Program {
        public static void Main (string[] args) {
            var host = CreateHostBuilder (args).Build ();
            using (var scope = host.Services.CreateScope ()) {
                var services = scope.ServiceProvider;
                try {
                    var context = services.GetRequiredService<DataContext> ();
                    var usermanager=services.GetRequiredService<UserManager<AppUser>>();
                    context.Database.Migrate ();
                    Seed.SeedData (context,usermanager).Wait();
                } catch (System.Exception ex) {

                    var logger = services.GetRequiredService<ILogger<Program>> ();
                    logger.LogError (ex, "Error happened during updating database!");
                }

                host.Run ();
            }

        }

        public static IHostBuilder CreateHostBuilder (string[] args) =>
            Host.CreateDefaultBuilder (args)
            .ConfigureWebHostDefaults (webBuilder => {
                webBuilder.UseStartup<Startup> ();
            });
    }
}