using Domain;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DAL.Abstract.TrainComponentContexts;

public interface ITrainComponentContextsRepository
{
    Task<int> Create(TrainComponentContext entity);
}