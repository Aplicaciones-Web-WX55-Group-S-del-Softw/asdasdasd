namespace si730ebu202210584.API.Observability.Interfaces.REST.Resource;

public record CreateThingStateResource(string Model, string ThingSerialNumber, int CurrentOperationMode,
    float CurrentTemperature, float CurrentHumidity, DateTime CollectedAt);