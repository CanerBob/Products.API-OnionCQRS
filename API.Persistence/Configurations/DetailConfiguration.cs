using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Persistence.Configurations;
public class DetailConfiguration : IEntityTypeConfiguration<Detail>
{
    public void Configure(EntityTypeBuilder<Detail> builder)
    {
        Detail detail1 = new() 
        { 
            Id = 1,
            Title = "Lorem falan filan",
            Description = "Açıklama falan filan",
            CategoryId = 1,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };
        Detail detail2 = new()
        {
            Id = 2,
            Title = "Lorem falan filan",
            Description = "Açıklama falan filan",
            CategoryId = 3,
            CreatedDate = DateTime.Now,
            IsDeleted = true,
        };
        Detail detail3 = new()
        {
            Id = 3,
            Title = "Lorem falan filan",
            Description = "Açıklama falan filan",
            CategoryId = 4,
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };
        builder.HasData(detail1, detail2, detail3);
    }
}