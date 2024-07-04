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
    
    public int Id { get; }
    public string Model { get; private set; }
    public string ThingSerialNumber { get; private set; }
    public int CurrentOperationMode { get; private set; }
    public float CurrentTemperature { get; private set; }
    public float CurrentHumidity { get; private set; }
    public DateTime CollectedAt { get; private set; }
}