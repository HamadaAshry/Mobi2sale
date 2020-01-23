using Domain;
using Domain.AdminPanel.Web.Addresses;
using Domain.AdminPanel.Web.Categories;
using Domain.AdminPanel.Web.Items;
using Domain.AdminPanel.Web.Offers;
using Domain.AdminPanel.Web.Subcategories;
using Domain.IdentityUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence {
    public class DataContext :IdentityDbContext<AppUser> {
        public DataContext (DbContextOptions<DataContext> options) : base (options) {

        }
        public DbSet<WeatherForcast> Forcasts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> Subcategories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Governorates> Governorates { get; set; }
        public DbSet<Districts> Districts { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating (ModelBuilder builder) {

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly (typeof (DataContext).Assembly);
          

        }
    }
}