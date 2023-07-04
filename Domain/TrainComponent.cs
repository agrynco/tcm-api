namespace Domain;

public class TrainComponent : Entity
{
    public required string Name { get; set; } = default!;
    public required string Number { get; set; } = default!;
    public bool CanAssignQuantity { get; set; }
}