using System.Diagnostics;
using System.Reflection;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Dal.EF;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TrainComponentContext> TrainComponentContexts { get; set; } = null!;
    public DbSet<TrainComponentRelation> TrainComponentRelations { get; set; } = null!;
    public DbSet<TrainComponent> TrainComponents { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ApplicationDbContext))!);
    }
}