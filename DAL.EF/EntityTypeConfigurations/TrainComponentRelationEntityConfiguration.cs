using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.EF.EntityTypeConfigurations;

public class TrainComponentRelationEntityConfiguration : IEntityTypeConfiguration<TrainComponentRelation>
{
    public void Configure(EntityTypeBuilder<TrainComponentRelation> builder)
    {
        builder.HasIndex(p => new
        {
            p.Id,
            p.TrainComponentId,
            p.TrainComponentParentId
        }).IsUnique();
    }
}