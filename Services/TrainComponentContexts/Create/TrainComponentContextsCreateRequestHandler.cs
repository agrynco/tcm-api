using DAL.Abstract.TrainComponentContexts;
using Domain;
using Serilog;
using Services.Core;

namespace Services.TrainComponentContexts.Create;

public class TrainComponentContextsCreateRequestHandler : RequestHandler<TrainComponentContextsCreateRequest, int>
{
    private readonly ITrainComponentContextsRepository _trainComponentContextsRepository;

    public TrainComponentContextsCreateRequestHandler(ILogger logger, 
        ITrainComponentContextsRepository trainComponentContextsRepository) : base(logger)
    {
        _trainComponentContextsRepository = trainComponentContextsRepository;
    }

    protected override async Task<int> DoOnHandle(TrainComponentContextsCreateRequest request)
    {
        return await _trainComponentContextsRepository.Create(new TrainComponentContext
        {
            Name = request.Name
        });
    }
}