using si730ebu202210584.API.Observability.Domain.Model;
using si730ebu202210584.API.Observability.Interfaces.REST.Resource;

namespace si730ebu202210584.API.Observability.Interfaces.REST.Transform;

public class ThingStateResourceFromEntityAssembler
{
    public static ThingStateResource ToResourceFromEntity(ThingState thingState)
    {
        return new ThingStateResource(
            thingState.Id,
            thingState.Model,
            thingState.ThingSerialNumber,
            thingState.CurrentOperationMode,
            thingState.CurrentTemperature,
            thingState.CurrentHumidity,
            thingState.CollectedAt
        );
    }
}