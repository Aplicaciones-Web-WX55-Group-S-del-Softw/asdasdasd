using si730ebu202210584.API.Inventory.Domain.Model.Aggregates;
using si730ebu202210584.API.Inventory.Interfaces.REST.Resources;

namespace si730ebu202210584.API.Inventory.Interfaces.REST.Transform;

public static class ThingResourceFromEntityAssembler
{
    public static ThingResource ToResourceFromEntity(Thing entity)
    {
        return new ThingResource(entity.Id, entity.SerialNumber.ToString(), entity.Model, entity.OperationMode, entity.MaximumTemperatureThreshold, entity.MinimumHumidityThreshold);
    }
    
}