using Enterprise_Server.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_Server.Configarations;

public class OrderComapundConfiguration : IEntityTypeConfiguration<OrderCompaund>
{

    public void Configure(EntityTypeBuilder<OrderCompaund> builder)
    {
        builder.HasKey(o => new { o.Id_Order, o.Id_Product });

        builder.HasOne(o => o.Order)
            .WithMany(o => o.OrderCompaunds);

        builder.HasOne(o => o.Product)
            .WithMany(p => p.OrderCompaunds);
    }
}
