namespace si730ebu202210584.API.Inventory.Domain.Model.Commands;

public record CreateThingCommand(string Model, string OperationMode, double MaximumTemperatureThreshold, double MinimumHumidityThreshold)
{
    
}