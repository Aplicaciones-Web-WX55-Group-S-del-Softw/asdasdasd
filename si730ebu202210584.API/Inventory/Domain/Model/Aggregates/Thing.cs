using si730ebu202210584.API.Inventory.Domain.Model.Commands;
using si730ebu202210584.API.Inventory.Domain.Model.ValueObjects;

namespace si730ebu202210584.API.Inventory.Domain.Model.Aggregates;

public class Thing
{
    public int Id { get; set; }
    public SerialNumber SerialNumber { get; set; }
    public string Model { get; set; }
    public string OperationMode { get; set; }
    public double MaximumTemperatureThreshold { get; set; }
    public double MinimumHumidityThreshold { get; set; }

    public Thing()
    {
    }
        
    public Thing(CreateThingCommand command)
    {
        SerialNumber = new SerialNumber();
        Model = command.Model;
        OperationMode = command.OperationMode;
        MaximumTemperatureThreshold = command.MaximumTemperatureThreshold;
        MinimumHumidityThreshold = command.MinimumHumidityThreshold;
        
    }
        
}
