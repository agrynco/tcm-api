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

        builder.HasData(new TrainComponentRelation
            {
                Id = 1,
                ContextId = 1,
                TrainComponentParentId = null,
                TrainComponentId = 2
            },
            new TrainComponentRelation
            {
                Id = 2,
                ContextId = 1,
                TrainComponentParentId = 2,
                TrainComponentId = 4,
                Quantity = 4
            },
            new TrainComponentRelation
            {
                Id = 3,
                ContextId = 1,
                TrainComponentParentId = 2,
                TrainComponentId = 7,
                Quantity = 4
            },
            new TrainComponentRelation
            {
                Id = 4,
                ContextId = 1,
                TrainComponentParentId = 2,
                TrainComponentId = 8,
                Quantity = 1
            },
            new TrainComponentRelation
            {
                Id = 5,
                ContextId = 1,
                TrainComponentParentId = null,
                TrainComponentId = 3
            },
            new TrainComponentRelation
            {
                Id = 6,
                ContextId = 1,
                TrainComponentParentId = 3,
                TrainComponentId = 18,
                Quantity = 1
            },
            new TrainComponentRelation
            {
                Id = 7,
                ContextId = 1,
                TrainComponentParentId = 3,
                TrainComponentId = 19,
                Quantity = 1
            });
    }
}