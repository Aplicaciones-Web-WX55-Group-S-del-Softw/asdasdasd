namespace si730ebu202210584.API.Observability.Domain.Model.Commands;

public record CreateThingStateCommand(
    string Model,
    string ThingSerialNumber,
    int CurrentOperationMode,
    float CurrentTemperature,
    float CurrentHumidity,
    DateTime CollectedAt)
{
    
}