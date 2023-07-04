using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.EF.EntityTypeConfigurations;

public class TrainComponentEntityConfiguration : IEntityTypeConfiguration<TrainComponent>
{
    public void Configure(EntityTypeBuilder<TrainComponent> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
        builder.HasIndex(p => p.Name).IsUnique();
        builder.Property(p => p.Number).IsRequired().HasMaxLength(10);
        builder.HasIndex(p => p.Number).IsUnique();
    }
}