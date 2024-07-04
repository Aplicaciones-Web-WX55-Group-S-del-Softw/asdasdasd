using si730ebu202210584.API.Observability.Domain.Model.Commands;
using si730ebu202210584.API.Observability.Interfaces.REST.Resource;

namespace si730ebu202210584.API.Observability.Interfaces.REST.Transform;

public static class CreateThingStateCommandFromResourceAssembler
{
    public static CreateThingStateCommand ToCommandFromResource(CreateThingStateResource resource)
    {
        return new CreateThingStateCommand(
            resource.Model,
            resource.ThingSerialNumber,
            resource.CurrentOperationMode,
            resource.CurrentTemperature,
            resource.CurrentHumidity,
            resource.CollectedAt
        );
    }
}