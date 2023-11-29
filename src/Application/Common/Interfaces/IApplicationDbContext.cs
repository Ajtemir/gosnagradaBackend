using Domain.Dictionary;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DatabaseFacade Database { get; }
    ChangeTracker ChangeTracker { get; }

    EntityEntry<T> Entry<T>(T entity) where T : class;

    DbSet<ApplicationUser> Users { get; }
    DbSet<ApplicationUserRole> UserRoles { get; }

    DbSet<Candidate> Candidates { get; }
    DbSet<Person> People { get; }
    DbSet<Citizen> Citizens { get; }
    DbSet<Mother> Mothers { get; }
    DbSet<Foreigner> Foreigners { get; }
    DbSet<Entity> Entities { get; }
    
    DbSet<RewardApplication> RewardApplications { get; }
    
    DbSet<Office> Offices { get; }

    DbSet<Position> Positions { get; }
    DbSet<Citizenship> Citizenships { get; }
    DbSet<Reward> Rewards { get; }
    DbSet<Education> Educations { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}