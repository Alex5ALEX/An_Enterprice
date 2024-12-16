using Enterprise_Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Enterprise_Server.Configarations;

public class SupplyComapundConfiguration : IEntityTypeConfiguration<SupplyCompaund>
{

    public void Configure(EntityTypeBuilder<SupplyCompaund> builder)
    {
        builder.HasKey(o => new { o.Id_Supply, o.Id_Material });

        builder.HasOne(o => o.Supply)
            .WithMany(o => o.SupplyCompaunds);

        builder.HasOne(o => o.Material)
            .WithMany(p => p.SupplyCompaunds);
    }
}
