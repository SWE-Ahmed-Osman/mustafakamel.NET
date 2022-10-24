using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Portfolio.Dashboard.Models;

namespace Portfolio.Database;

public interface IPortfolioContext
{
    int SaveChanges();
    DbSet<Mustafa> Mustafa { get; }
    DatabaseFacade Database { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}