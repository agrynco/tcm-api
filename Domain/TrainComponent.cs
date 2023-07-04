namespace Domain;

public class TrainComponent : Entity
{
    public TrainComponent()
    {
    }

    public TrainComponent(string name, string number, bool canAssignQuantity)
    {
        Name = name;
        Number = number;
        CanAssignQuantity = canAssignQuantity;
    }

    public required string Name { get; set; } = default!;
    public required string Number { get; set; } = default!;
    public bool CanAssignQuantity { get; set; }
}