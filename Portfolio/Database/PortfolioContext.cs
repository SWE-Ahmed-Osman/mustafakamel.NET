using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Dashboard.Models;

namespace Portfolio.Database;

public class PortfolioContext : IdentityDbContext, IPortfolioContext
{
    public DbSet<Mustafa> Mustafa => Set<Mustafa>();

    public PortfolioContext(DbContextOptions option) : base(option)
    {
    }
}