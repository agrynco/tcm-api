namespace Services.TrainComponentRelations.Create;

public class TrainComponentSelfReferenceException : Exception
{
    public TrainComponentSelfReferenceException(TrainComponentRelationsCreateRequest request) 
        : base($"{request.TrainComponentId} and {request.TrainComponentParentId} cannot be the same")
    {
    }
    
    public TrainComponentRelationsCreateRequest Request { get; init; }
}