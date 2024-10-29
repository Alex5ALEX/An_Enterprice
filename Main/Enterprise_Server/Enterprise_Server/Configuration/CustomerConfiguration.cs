using Enterprise_Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Enterprise_Server.Configuration;

public class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasMany(a => a.Orders).WithOne(a => a.Customer);
    }
}

