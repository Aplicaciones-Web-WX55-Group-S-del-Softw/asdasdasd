using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;
using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Observability.Domain.Model;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

namespace si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Configuration
{
    public class AppDbContext : DbContext
    {    

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.AddCreatedUpdatedInterceptor();
            base.OnConfiguring(builder);

            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Thing>().ToTable("Things");
            builder.Entity<Thing>().HasKey(e => e.Id);
            builder.Entity<Thing>().Property(e => e.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Thing>().Property(e => e.Model);
            builder.Entity<Thing>().Property(e => e.OperationMode).IsRequired();
            builder.Entity<Thing>().Property(e => e.MaximumTemperatureThreshold).IsRequired();
            builder.Entity<Thing>().Property(e => e.MinimumHumidityThreshold).IsRequired();
            builder.Entity<Thing>().OwnsOne(i => i.SerialNumber,
                ai =>
                {
                    ai.WithOwner().HasForeignKey("Id");
                });
            
            builder.Entity<Thing>().ToTable("ThingStates");
            builder.Entity<ThingState>().HasKey(s => s.Id);
            builder.Entity<ThingState>().Property(s => s.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<ThingState>().Property(s => s.Model).IsRequired();
            builder.Entity<ThingState>().Property(s => s.CurrentOperationMode).IsRequired();
            builder.Entity<ThingState>().Property(s => s.ThingSerialNumber).IsRequired();
            builder.Entity<ThingState>().Property(s => s.CurrentHumidity).IsRequired();
            builder.Entity<ThingState>().Property(s => s.CurrentTemperature).IsRequired();
            builder.Entity<ThingState>().Property(s => s.CollectedAt).IsRequired();

            builder.Entity<Thing>()
                .HasMany(s => s.ThingStates);
        
            // Apply SnakeCase Naming Convention
            builder.UseSnakeCaseNamingConvention();
        }
    }
}