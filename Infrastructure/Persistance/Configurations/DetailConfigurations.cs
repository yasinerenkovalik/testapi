using Api.Domain.Commen.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations;

public class DetailConfigurations:IEntityTypeConfiguration<Detail>
{
    public void Configure(EntityTypeBuilder<Detail> builder)
    {
        Faker faker = new("tr");
        Detail detail = new()
        {
            Id = 1,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 1,
            CreateDateTime = DateTime.Now,
            IsDeleted = false,
            

        };
        Detail detail2 = new()
        {
            Id = 2,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 4,
            CreateDateTime = DateTime.Now,
            IsDeleted = true

        };
        Detail detail3 = new()
        {
            Id = 3,
            Title = faker.Lorem.Sentence(1),
            Description = faker.Lorem.Sentence(5),
            CategoryId = 3,
            CreateDateTime = DateTime.Now,
            IsDeleted = false

        };
        builder.HasData(detail, detail2, detail3);

    }
}