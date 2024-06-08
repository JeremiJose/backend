using CenterManagement.centerManagement.Domain.Model.Aggregates;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CenterManagement.Shared.Infraestructure.Persistence.EFC.Configuration;

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
        // Place Context
        builder.Entity<Place>().ToTable("Place");
        builder.Entity<Place>().HasKey(e => e.Id);
        builder.Entity<Place>().Property(e => e.Name).IsRequired();
        builder.Entity<Place>().Property(e => e.Address).IsRequired();
        builder.Entity<Place>().Property(e => e.Capacity).IsRequired();
        builder.Entity<Place>().Property(e => e.Ruc).IsRequired();
        // Company Context
        builder.Entity<Company>().ToTable("Company");
        builder.Entity<Company>().HasKey(e => e.Id);
        builder.Entity<Company>().Property(e => e.Name).IsRequired();
        builder.Entity<Company>().Property(e => e.IdPlace).IsRequired();
        builder.Entity<Company>().Property(e => e.QuantityOrganizer).IsRequired();
        // Headquarters Context
        builder.Entity<Headquarters>().ToTable("Headquarters");
        builder.Entity<Headquarters>().HasKey(e => e.Id);
        builder.Entity<Headquarters>().Property(e => e.Name).IsRequired();
        builder.Entity<Headquarters>().Property(e => e.IdPlace).IsRequired();
        builder.Entity<Headquarters>().Property(e => e.Capacity).IsRequired();
    }
}