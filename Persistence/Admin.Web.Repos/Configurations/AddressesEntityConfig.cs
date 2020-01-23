using System;
using System.Collections.Generic;
using CommonHelpers;
using Domain.AdminPanel.Web.Addresses;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Admin.Web.Repos.Configurations
{
    public class AddressesEntityConfig : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.ToTable("lkp_Countries", "Admin");
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id).HasColumnName("pk_Countries_Id");
            builder.Property(p => p.Name).IsRequired();
            builder.HasMany<Governorates>(p => p.Governorates).WithOne(p => p.Countries).
            HasForeignKey(p => p.CountryId);
        }
    }
    public class AddressesGovernoratesEntityConfig : IEntityTypeConfiguration<Governorates>
    {
        public void Configure(EntityTypeBuilder<Governorates> builder)
        {
            builder.ToTable("lkp_Governorates", "Admin");
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id).HasColumnName("pk_Governorates_Id");
            builder.Property(p => p.Name).IsRequired();
            builder.HasMany<Districts>(p => p.Districts).WithOne(p => p.Governorates).
            HasForeignKey(p => p.GovernorateId);
        }
    }
    public class AddressesDistrictsEntityConfig : IEntityTypeConfiguration<Districts>
    {
        public void Configure(EntityTypeBuilder<Districts> builder)
        {
            builder.ToTable("lkp_Districts", "Admin");
            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id).HasColumnName("pk_Districts_Id");
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
