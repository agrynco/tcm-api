using DAL.Abstract.TrainComponentRelations;
using Serilog;
using Services.Core;

namespace Services.TrainComponentRelations.Get;

public class
    TrainComponentRelationsGetRequestHandler : RequestHandler<TrainComponentRelationsGetRequest,
        TrainComponentRelationItem[]>
{
    private readonly ITrainComponentRelationsRepository _trainComponentRelationsRepository;

    public TrainComponentRelationsGetRequestHandler(ILogger logger,
        ITrainComponentRelationsRepository trainComponentRelationsRepository) : base(logger)
    {
        _trainComponentRelationsRepository = trainComponentRelationsRepository;
    }

    protected override async Task<TrainComponentRelationItem[]> DoOnHandle(TrainComponentRelationsGetRequest request)
    {
        return await _trainComponentRelationsRepository.Get(request.TrainComponentContextId,
            request.TrainComponentParentId);
    }
}