using DAL.Abstract.TrainComponentRelations;
using SlimMessageBus;

namespace Services.TrainComponentRelations.Get;

public class TrainComponentRelationsGetRequest : IRequest<TrainComponentRelationItem[]>
{
    public int TrainComponentContextId { get; init; }
    public int? TrainComponentParentId { get; init; }
}