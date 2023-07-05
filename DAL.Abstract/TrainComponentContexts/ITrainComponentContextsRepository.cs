using Domain;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DAL.Abstract.TrainComponentContexts;

public interface ITrainComponentContextsRepository: ICreateRepository<TrainComponentContext>
{
    Task<int> Create(TrainComponentContext entity);
}