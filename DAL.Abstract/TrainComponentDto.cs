namespace DAL.Abstract;

public class TrainComponentDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Number { get; init; }
    public bool CanAssignQuantity { get; init; }
}