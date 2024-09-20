using Api.Domain.Commen.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations;

public class BrandConfigurations:IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(256);
        Faker fake = new ("tr");
        Brand brand=new ()
        {
            Id = 1,
            Name = fake.Commerce.Department(),
            CreateDateTime = DateTime.Now,
            IsDeleted = false
        };
        Brand brand1=new ()
        {
            Id = 2,
            Name = fake.Commerce.Department(),
            CreateDateTime = DateTime.Now,
            IsDeleted = false
        };
        Brand brand2=new ()
        {
            Id = 3,
            Name = fake.Commerce.Department(),
            CreateDateTime = DateTime.Now,
            IsDeleted = true
        };
        builder.HasData(brand,brand1,brand2);


    }
}