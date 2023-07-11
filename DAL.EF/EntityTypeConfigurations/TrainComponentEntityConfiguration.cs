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

        builder.HasData(
            new TrainComponent
            {
                Id = 1,
                Name = "Engine",
                Number = "ENG123",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 2,
                Name = "Passenger Car",
                Number = "PAS456",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 3,
                Name = "Freight Car",
                Number = "FRT789",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 4,
                Name = "Wheel",
                Number = "WHL101",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 5,
                Name = "Seat",
                Number = "STS234",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 6,
                Name = "Window",
                Number = "WIN567",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 7,
                Name = "Door",
                Number = "DR123",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 8,
                Name = "Control Panel",
                Number = "CTL987",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 9,
                Name = "Light",
                Number = "LGT456",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 10,
                Name = "Brake",
                Number = "BRK789",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 11,
                Name = "Bolt",
                Number = "BLT321",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 12,
                Name = "Nut",
                Number = "NUT654",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 13,
                Name = "Engine Hood",
                Number = "EH789",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 14,
                Name = "Axle",
                Number = "AX456",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 15,
                Name = "Piston",
                Number = "PST789",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 16,
                Name = "Handrail",
                Number = "HND234",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 17,
                Name = "Step",
                Number = "STP567",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 18,
                Name = "Roof",
                Number = "RF123",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 19,
                Name = "Air Conditioner",
                Number = "AC789",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 20,
                Name = "Flooring",
                Number = "FLR456",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 21,
                Name = "Mirror",
                Number = "MRR789",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 22,
                Name = "Horn",
                Number = "HRN321",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 23,
                Name = "Coupler",
                Number = "CPL654",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 24,
                Name = "Hinge",
                Number = "HNG987",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 25,
                Name = "Ladder",
                Number = "LDR456",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 26,
                Name = "Paint",
                Number = "PNT789",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 27,
                Name = "Decal",
                Number = "DCL321",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 28,
                Name = "Gauge",
                Number = "GGS654",
                CanAssignQuantity = true
            },
            new TrainComponent
            {
                Id = 29,
                Name = "Battery",
                Number = "BTR987",
                CanAssignQuantity = false
            },
            new TrainComponent
            {
                Id = 30,
                Name = "Radiator",
                Number = "RDR456",
                CanAssignQuantity = false
            }
        );
    }
}