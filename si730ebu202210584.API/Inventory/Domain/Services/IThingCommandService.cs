using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Inventory.Domain.Model.Commands;

namespace si730ebu202210584.API.Inventory.Domain.Services;

public interface IThingCommandService
{
    Task<Thing> Handle(CreateThingCommand command);
}