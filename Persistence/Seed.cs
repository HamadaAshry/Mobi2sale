using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Persistence;
using Domain.AdminPanel.Web.Categories;
using Domain.IdentityUsers;
using Microsoft.AspNetCore.Identity;
//using Domain.IdentityUsers;
// using Microsoft.AspNetCore.Identity;

namespace Persistence {
    public class Seed {

        public static async Task SeedData (DataContext context, UserManager<AppUser> userManager) {
            var users = new List<AppUser> () {
                //    new AppUser () {
                //    UserName = "Admin",
                //    Email = "admin@test.com",
                //    },
                   new AppUser () {
                       UserName = "SuperAdmin",
                       Email = "superadmin@test.com",
                   },
            };
           if (!userManager.Users.Any ()) {
               
               };

               foreach (var user in users) {
                  await userManager.CreateAsync(user,"Pa$$w0rd");
               }
           }

           // if (!context.Categories.Any ()) {
           //     var categories = new List<Category> () {
           //         new Category () { Name = "Mobiles", ImageUrl = "https://www.gizbot.com/images/2019-02/vivo-u1_155107538060.jpg" },
           //         new Category () { Name = "Accessories", ImageUrl = "https://www.shutterstock.com/image-photo/usb-charging-cables-smartphone-tablet-top-587625662" },
           //     };

           //   context.Categories.AddRange(categories);
           //   context.SaveChanges();

           // }
        }
    }
