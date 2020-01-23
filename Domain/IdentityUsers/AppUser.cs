using Microsoft.AspNetCore.Identity;

namespace Domain.IdentityUsers
{
   public class AppUser:IdentityUser
   {
       public string MacAddress { get; set; }
   }
}