using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Inventory.Domain.Repositories;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace si730ebu202210584.API.Inventory.Infrastructure.Persistence.EFC.Repositories;

public class ThingRepository : BaseRepository<Thing>,IThingRepository
{
    public ThingRepository(AppDbContext context) : base(context)
    {
    }
}