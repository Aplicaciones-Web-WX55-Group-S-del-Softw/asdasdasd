namespace si730ebu202210584.API.Observability.Domain.Model.Commands;

public class CreateThingStateCommand(
    string Model,
    string ThingSerialNumber,
    int CurrentOperationMode,
    float CurrentTemperature,
    float CurrentHumidity,
    DateTime CollectedAt)
{
    
}