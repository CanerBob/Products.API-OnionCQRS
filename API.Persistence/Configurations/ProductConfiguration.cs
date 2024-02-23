using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Persistence.Configurations;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        Product p1 = new() 
        { 
            Id = 1,
            Title = "Ürün Başlığı falan filan",
            Description = "Ürün AÇıklaması falan filan",
             BrandId = 1,
             Discount = 5,
             Price = 1000,
             CreatedDate = DateTime.Now,
             IsDeleted = false,
        };
        Product p2 = new()
        {
            Id =2,
            Title = "Ürün Başlığı falan filan",
            Description = "Ürün AÇıklaması falan filan",
            BrandId = 3,
            Discount = 5,
            Price = 1000,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };
        builder.HasData(p1,p2);
    }
}