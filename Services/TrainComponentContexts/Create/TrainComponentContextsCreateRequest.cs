using SlimMessageBus;

namespace Services.TrainComponentContexts.Create;

public class TrainComponentContextsCreateRequest : IRequest<int>
{
    public required string Name { get; init; }
}