using CommonHelpers;
using Domain.AdminPanel.Web.Items;
using Domain.AdminPanel.Web.Subcategories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Admin.Web.Repos.Configurations {
    public class ItemConfigurations : IEntityTypeConfiguration<Item> {
        public void Configure (EntityTypeBuilder<Item> builder) {
            builder.ToTable ("tbl_Items", "Products");
            builder.HasKey (k => k.Id);
            builder.Property (p => p.Id).HasColumnName ("pk_Items_Id");
            builder.Property (p => p.SubcategoryId).HasColumnName ("fk_subCategories_Items_SubcategoryId");
            builder.Property (p => p.Name).IsRequired ();
            builder.Property (p => p.MainImageUrl).IsRequired ();
            builder.Property (p => p.CoverImageUrl).IsRequired ();
            builder.Property (p => p.Code).IsRequired ();
            builder.Property (p => p.SupplyPrice).HasColumnType ("money");
            builder.Property (p => p.WholesalePrice).HasColumnType ("money");
            builder.Property (p => p.RetailPrice).HasColumnType ("money");
            builder.Property (p => p.CraetedAt).HasDefaultValue (DateTimeService.GetCurrentDateTime ());
            builder.Property (p => p.ModifiedAt).HasDefaultValue (DateTimeService.GetCurrentDateTime ());
            builder.Property (p => p.IsDeleted).HasDefaultValue (false);
            builder.HasOne<SubCategory>(p=>p.Subcategory).WithMany(p=>p.Items).HasForeignKey(p=>p.SubcategoryId);
        }
    }
}