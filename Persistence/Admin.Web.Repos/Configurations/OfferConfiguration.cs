using CommonHelpers;
using Domain.AdminPanel.Web.Offers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Admin.Web.Repos.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.ToTable("tbl_Offers","Sales");
            builder.HasKey(k=>k.Id).HasName("pk_Offers_Id");
            builder.Property(p=>p.Name).IsRequired();
            builder.Property(p=>p.ItemId).IsRequired();
            builder.Property(p=>p.StartDate).IsRequired();
            builder.Property(p=>p.EndDate).IsRequired();            
            builder.Property(p=>p.ImageUrl).IsRequired();
            builder.Property(p=>p.OfferPrice).HasColumnType("money");
            builder.Property(p=>p.CraetedAt).HasDefaultValue(DateTimeService.GetCurrentDateTime());
            builder.Property(p=>p.ModifiedAt).HasDefaultValue(DateTimeService.GetCurrentDateTime());
            builder.Property(p=>p.IsDeleted).HasDefaultValue(false);
        }
    }
}