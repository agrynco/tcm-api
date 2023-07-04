using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.EF.EntityTypeConfigurations;

public class TrainComponentContextEntityConfiguration : IEntityTypeConfiguration<TrainComponentContext>
{
    public void Configure(EntityTypeBuilder<TrainComponentContext> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(250);
        builder.HasIndex(p => p.Name).IsUnique();

        builder.HasData(new TrainComponentContext
        {
            Id = 1,
            Name = "Main"
        });
    }
}