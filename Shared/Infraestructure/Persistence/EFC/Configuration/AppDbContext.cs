using Backend_MyEventec.EventAndTicketing.Domain.Model.Aggregates;
using Backend_MyEventec.Shared.Infraestructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Backend_MyEventec.Shared.Infraestructure.Persistence.EFC.Configuration;

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
        // Event Context
        builder.Entity<Event>().ToTable("Event");
        builder.Entity<Event>().HasKey(e => e.Id);
        builder.Entity<Event>().Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Event>().Property(e => e.IdHeadquarters).IsRequired();
        builder.Entity<Event>().Property(e => e.IdOrganizer).IsRequired();
        builder.Entity<Event>().Property(e => e.Name).IsRequired();
        builder.Entity<Event>().Property(e => e.StartDate).IsRequired();
        builder.Entity<Event>().Property(e => e.FinishDate).IsRequired();
        builder.Entity<Event>().Property(e => e.Description).IsRequired();
        builder.Entity<Event>().Property(e => e.TotalTicket).IsRequired();
        builder.Entity<Event>().Property(e => e.Status).IsRequired();
        
        // Ticket Configuration
        builder.Entity<Ticket>().ToTable("Tickets");
        builder.Entity<Ticket>().HasKey(t => t.Id);
        builder.Entity<Ticket>().Property(t => t.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Ticket>().Property(t => t.EventId).IsRequired();
        builder.Entity<Ticket>().Property(t => t.ClientId).IsRequired();
        builder.Entity<Ticket>().Property(t => t.Price).IsRequired();
        builder.Entity<Ticket>().Property(t => t.Category).IsRequired();
        
        builder.UseSnakeCaseWithPluralizedTableNamingConvention();
    }
}