using DAL.Abstract.TrainComponentContexts;
using DAL.EF.Core;
using Domain;

namespace Dal.EF.Repositories;

public class TrainComponentContextsRepository : BaseRepository<TrainComponentContext>, ITrainComponentContextsRepository
{
    public TrainComponentContextsRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public async Task<int> Create(TrainComponentContext entity)
    {
        return (await EfRepository.AddAsync(entity)).Id;
    }
}