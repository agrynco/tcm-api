using DAL.Abstract.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DAL.EF.Core;

public class TransactionRepository<TDbContext> : ITransactionRepository
    where TDbContext : DbContext
{
    private readonly TDbContext _dbContext;

    public TransactionRepository(TDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IDbContextTransaction BeginTransaction()
    {
        return _dbContext.Database.BeginTransaction();
    }

    public async Task<IDbContextTransaction> BeginTransactionAsync()
    {
        return await _dbContext.Database.BeginTransactionAsync();
    }
}