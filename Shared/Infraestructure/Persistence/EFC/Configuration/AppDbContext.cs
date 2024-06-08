using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using UserManagement.userManagement.Domain.Model.Aggregates;

namespace UserManagement.Shared.Infraestructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options): DbContext(options) 
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // User Context
        builder.Entity<User>().ToTable("User");
        builder.Entity<User>().HasKey(u => u.Id);
        builder.Entity<User>().Property(u => u.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<User>().Property(u => u.IdWallet).IsRequired();
        builder.Entity<User>().Property(u => u.FirstName).IsRequired();
        builder.Entity<User>().Property(u => u.LastName).IsRequired();
        builder.Entity<User>().Property(u => u.Address).IsRequired();
        builder.Entity<User>().Property(u => u.Email).IsRequired();
        builder.Entity<User>().Property(u => u.Phone).IsRequired();
        builder.Entity<User>().Property(u => u.Password).IsRequired();
        builder.Entity<User>().Property(u => u.CreationDate).IsRequired();
        builder.Entity<User>().Property(u => u.SuspensionDate).IsRequired(false);
        
        // Client Context
        builder.Entity<Client>().ToTable("Client");
        builder.Entity<Client>().HasKey(c => c.Id);
        builder.Entity<Client>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Client>().Property(c => c.UserId).IsRequired();
        
        // Organizer Context
        builder.Entity<Organizer>().ToTable("Organizer");
        builder.Entity<Organizer>().HasKey(o => o.Id);
        builder.Entity<Organizer>().Property(o => o.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Organizer>().Property(o => o.CompanyId).IsRequired();
        builder.Entity<Organizer>().Property(o => o.UserId).IsRequired();
        builder.Entity<Organizer>().Property(o => o.EventsInCharge).IsRequired();
    }
}
