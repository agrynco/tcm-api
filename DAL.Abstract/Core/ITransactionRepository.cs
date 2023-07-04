using Microsoft.EntityFrameworkCore.Storage;

namespace DAL.Abstract.Core;

public interface ITransactionRepository
{
    IDbContextTransaction BeginTransaction();
    Task<IDbContextTransaction> BeginTransactionAsync();
}