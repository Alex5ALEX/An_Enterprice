using Enterprise_Server.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Enterprise_Server.Configarations;

public class MaterialComapundConfiguration : IEntityTypeConfiguration<MaterialCompaund>
{

    public void Configure(EntityTypeBuilder<MaterialCompaund> builder)
    {
        builder.HasKey(o => new { o.Id_Material, o.Id_Product });

        builder.HasOne(o => o.Material)
            .WithMany(o => o.MaterialCompaunds);

        builder.HasOne(o => o.Product)
            .WithMany(p => p.MaterialCompaunds);
    }
}