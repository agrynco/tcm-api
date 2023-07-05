namespace Services.TrainComponentRelations;

public class TrainComponentRelationsCreateRequest
{
    public int TrainComponentId { get; init; }
    public int? TrainComponentParentId { get; init; }
    public int TrainComponentContextId { get; init; }
}