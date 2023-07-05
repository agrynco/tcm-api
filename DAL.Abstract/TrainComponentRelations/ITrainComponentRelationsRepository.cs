using Domain;

namespace DAL.Abstract.TrainComponentRelations;

public interface ITrainComponentRelationsRepository : ICreateRepository<TrainComponentRelation>
{
    Task<int> Create(TrainComponentRelation entity);
}