namespace si730ebu202210584.API.Inventory.Interfaces.REST.Resources;

public record CreateThingResource( string Model, string OperationMode, double MaximumTemperatureThreshold, double MinimumHumidityThreshold)
{
    
};