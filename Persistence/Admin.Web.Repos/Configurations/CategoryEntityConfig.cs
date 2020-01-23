using System;
using CommonHelpers;
using Domain.AdminPanel.Web.Categories;
using Domain.AdminPanel.Web.Subcategories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Admin.Web.Repos.Configurations
{
    public class CategoryEntityConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("tbl_Categories","Products");
            builder.HasKey(k=>k.Id).HasName("pk_Categories_Id");
            builder.Property(p=>p.Name).IsRequired();
            builder.Property(p=>p.ImageUrl).IsRequired();
            builder.Property(p=>p.CraetedAt).HasDefaultValue(DateTimeService.GetCurrentDateTime());
            builder.Property(p=>p.ModifiedAt).HasDefaultValue(DateTimeService.GetCurrentDateTime());
            builder.Property(p=>p.IsDeleted).HasDefaultValue(false);
            builder.HasMany<SubCategory>(p=>p.Subcategories).WithOne(p=>p.Category).
            HasForeignKey(p=>p.CategoryId);

           
        }
    }
}