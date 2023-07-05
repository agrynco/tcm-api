using DAL.Abstract.TrainComponentRelations;
using Domain;
using Serilog;
using Services.Core;

namespace Services.TrainComponentRelations;

public class TrainComponentRelationsCreateRequestHandler : RequestHandler<TrainComponentRelationsCreateRequest, int>
{
    private readonly ITrainComponentRelationsRepository _trainComponentRelationsRepository;

    public TrainComponentRelationsCreateRequestHandler(ILogger logger,
        ITrainComponentRelationsRepository trainComponentRelationsRepository) : base(logger)
    {
        _trainComponentRelationsRepository = trainComponentRelationsRepository;
    }

    protected override async Task<int> DoOnHandle(TrainComponentRelationsCreateRequest request)
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