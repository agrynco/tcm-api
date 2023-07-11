namespace DAL.Abstract.TrainComponentRelations;

public record TrainComponentRelationItem
{
    public int Id { get; init; }
    public int? Quantity { get; init; }
    public TrainComponentDto TrainComponent { get; init; }
}