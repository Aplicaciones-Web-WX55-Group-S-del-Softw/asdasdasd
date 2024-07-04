using si730ebu202210584.API.Observability.Domain.Model.Commands;

namespace si730ebu202210584.API.Observability.Domain.Model;

public partial class ThingState
{
    
    public ThingState(string model, string thingSerialNumber, int currentOperationMode,
        float currentTemperature, float currentHumidity, DateTime collectedAt)
    {
        Model = model;
        ThingSerialNumber = thingSerialNumber;
        CurrentOperationMode = currentOperationMode;
        CurrentTemperature = currentTemperature;
        CurrentHumidity = currentHumidity;
        CollectedAt = collectedAt;

    }
    public ICollection<ThingState> ThingStates { get; }

    public int Id { get; }
    public string Model { get; private set; }
    public string ThingSerialNumber { get; private set; }
    public int CurrentOperationMode { get; private set; }
    public float CurrentTemperature { get; private set; }
    public float CurrentHumidity { get; private set; }
    public DateTime CollectedAt { get; private set; }

    public ThingState(CreateThingStateCommand command)
    {
        Model = command.Model;
        ThingSerialNumber = command.ThingSerialNumber;
        CurrentOperationMode = command.CurrentOperationMode;
        CurrentTemperature = command.CurrentTemperature;
        CurrentHumidity = command.CurrentHumidity;
        CollectedAt = command.CollectedAt;
        
    }
}
