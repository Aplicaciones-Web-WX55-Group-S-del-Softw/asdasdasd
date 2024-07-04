using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;
using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Inventory.Domain.Model.Commands;
using si730ebu202210584.API.Inventory.Domain.Repositories;
using si730ebu202210584.API.Inventory.Domain.Services;
using si730ebu202210584.API.Inventory.Infrastructure.Persistence.EFC.Repositories;

namespace si730ebu202210584.API.Inventory.Application.Internal.CommandServices;

public class ThingCommandService : IThingCommandService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IThingRepository _thingRepository;

    public ThingCommandService(IUnitOfWork unitOfWork, IThingRepository thingRepository)
    {
        _unitOfWork = unitOfWork;
        this._thingRepository = thingRepository;
    }

    public async Task<Thing> Handle(CreateThingCommand command)
    {  var thing = new Thing(command);
        await _thingRepository.AddAsync(thing);
        await _unitOfWork.CompleteAsync();
        return thing;
        
    }
}