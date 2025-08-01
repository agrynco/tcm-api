using DAL.Abstract;
using DAL.Abstract.TrainComponentRelations;
using DAL.EF.Core;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Dal.EF.Repositories;

public class TrainComponentRelationsRepository : BaseRepository<TrainComponentRelation>,
    ITrainComponentRelationsRepository
{
    public TrainComponentRelationsRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    private IQueryable<TrainComponentRelation> TrainComponentRelations =>
        EfRepository.DbContext.TrainComponentRelations;

    private IQueryable<TrainComponent> TrainComponents => EfRepository.DbContext.TrainComponents;

    public async Task<int> Create(TrainComponentRelation entity)
    {
        return (await EfRepository.AddAsync(entity)).Id;
    }

    public async Task<TrainComponentRelationItem[]> Get(int trainComponentContextId, int? parentComponentId)
    {
        return await (from tcr in TrainComponentRelations
            join tc in TrainComponents on tcr.TrainComponentId equals tc.Id into joinedTrainComponents
            from joinedTrainComponent in joinedTrainComponents.DefaultIfEmpty()
            where tcr.TrainComponentParentId == parentComponentId &&
                  tcr.ContextId == trainComponentContextId
            select new TrainComponentRelationItem
            {
                Id = tcr.Id,
                TrainComponent = new TrainComponentDto
                {
                    Id = joinedTrainComponent.Id,
                    Name = joinedTrainComponent.Name,
                    Number = joinedTrainComponent.Number,
                    CanAssignQuantity = joinedTrainComponent.CanAssignQuantity
                },
                Quantity = tcr.Quantity
            }).ToArrayAsync();
    }
}