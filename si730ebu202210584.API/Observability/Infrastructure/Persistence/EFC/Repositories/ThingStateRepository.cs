using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Inventory.Domain.Repositories;
using si730ebu202210584.API.Observability.Domain.Model;
using si730ebu202210584.API.Observability.Domain.Repositories;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730ebu202210584.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace si730ebu202210584.API.Observability.Infrastructure.Persistence.EFC.Repositories;

public class ThingStateRepository : BaseRepository<ThingState>, IThingStateRepository
{
    public ThingStateRepository(AppDbContext context) : base(context)
    {
    }


}