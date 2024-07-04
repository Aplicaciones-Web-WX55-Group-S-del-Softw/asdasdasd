namespace si730ebu202210584.API.Inventory.Interfaces.REST.Resources;

public record ThingResource( int id, string SerialNumber, string Model, string OperationMode, double MaximumTemperatureThreshold, double MinimumHumidityThreshold)
{
    
}