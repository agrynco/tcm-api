using Domain;

namespace DAL.Abstract;

public interface ICreateRepository<in TEntity> where TEntity : Entity
{
    Task<int> Create(TEntity entity);
}