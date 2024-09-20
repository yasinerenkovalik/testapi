using Api.Domain.Commen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations;

public class CategoryConfigurations:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        Category category1 = new()
        {
            Id = 1,
            Name = "elektrik",
            Priority = 1,
            ParentId = 0,
            IsDeleted = false,
            CreateDateTime = DateTime.Now
        };
        Category category2 = new()
        {
            Id = 2,
            Name = "moda",
            Priority = 2,
            ParentId = 0,
            IsDeleted = false,
            CreateDateTime = DateTime.Now
        };
        Category category3 = new()
        {
            Id = 3,
            Name = "bilgisayar",
            Priority = 1,
            ParentId = 1,
            IsDeleted = false,
            CreateDateTime = DateTime.Now
        };
        Category category4 = new()
        {
            Id = 4,
            Name = "kadın",
            Priority = 1,
            ParentId = 2,
            IsDeleted = false,
            CreateDateTime = DateTime.Now
        };
        builder.HasData(category1, category2, category3, category4);
    }
}