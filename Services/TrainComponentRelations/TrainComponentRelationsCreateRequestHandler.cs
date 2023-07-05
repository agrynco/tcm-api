using DAL.Abstract.TrainComponentRelations;
using Domain;

namespace Services.TrainComponentRelations;

public class TrainComponentRelationsCreateRequestHandler
{
    private readonly ITrainComponentRelationsRepository _trainComponentRelationsRepository;

    public TrainComponentRelationsCreateRequestHandler(
        ITrainComponentRelationsRepository trainComponentRelationsRepository)
    {
        _trainComponentRelationsRepository = trainComponentRelationsRepository;
    }

    public async Task<int> Handle(TrainComponentRelationsCreateRequest request, CancellationToken cancellationToken)
    {
        if (request.TrainComponentId == request.TrainComponentParentId)
        {
            throw new TrainComponentSelfReferenceException(request);
        }
        
        return await _trainComponentRelationsRepository.Create(new TrainComponentRelation
        {
            ContextId = request.TrainComponentContextId,
            TrainComponentId = request.TrainComponentId,
            TrainComponentParentId = request.TrainComponentParentId
        });
    }
}