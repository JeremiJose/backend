using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using Paymethods.paymethods.Domain.Model.Aggregates;

namespace Paymethods.Shared.Infraestructure.Persistence.EFC.Configuration
{
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
            // Card Context
            builder.Entity<Card>().ToTable("Card");
            builder.Entity<Card>().HasKey(c => c.Id);
            builder.Entity<Card>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Card>().Property(c => c.IdWallet).IsRequired();
            builder.Entity<Card>().Property(c => c.Number).IsRequired();
            builder.Entity<Card>().Property(c => c.DueDate).IsRequired();
            builder.Entity<Card>().Property(c => c.CssCode).IsRequired();
            
            // Wallet Context
            builder.Entity<Wallet>().ToTable("Wallet");
            builder.Entity<Wallet>().HasKey(w => w.Id);
            builder.Entity<Wallet>().Property(w => w.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Wallet>().Property(w => w.QuantityCard).IsRequired();
            builder.Entity<Wallet>().Property(w => w.CreationDate).IsRequired();
            builder.Entity<Wallet>().Property(w => w.UserId).IsRequired();
        }
    }
}