using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Inventory.Domain.Model.Commands;
using si730ebu202210584.API.Observability.Domain.Model;
using si730ebu202210584.API.Observability.Domain.Model.Commands;

namespace si730ebu202210584.API.Observability.Domain.Services;

public interface IThingStateCommandService
{    
    
    Task<ThingState> Handle(CreateThingStateCommand command);
    
}