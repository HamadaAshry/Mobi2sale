using CommonHelpers;
using Domain.AdminPanel.Web.Subcategories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Admin.Web.Repos.Configurations
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.ToTable("tbl_SubCategories","Products");
            builder.HasKey(k=>k.Id).HasName("pk_SubCategories_Id");
            builder.Property(p=>p.Name).IsRequired();
            builder.Property(p=>p.ImageUrl).IsRequired();
            builder.Property(p=>p.CraetedAt).HasDefaultValue(DateTimeService.GetCurrentDateTime());
            builder.Property(p=>p.ModifiedAt).HasDefaultValue(DateTimeService.GetCurrentDateTime());
            builder.Property(p=>p.IsDeleted).HasDefaultValue(false);
        }
    }
}