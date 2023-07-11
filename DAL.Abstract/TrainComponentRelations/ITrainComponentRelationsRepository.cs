using Domain;

namespace DAL.Abstract.TrainComponentRelations;

public interface ITrainComponentRelationsRepository : ICreateRepository<TrainComponentRelation>
{
    Task<TrainComponentRelationItem[]> Get(int trainComponentContextId, int? parentComponentId);
}