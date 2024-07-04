namespace si730ebu202210584.API.Inventory.Domain.Model.ValueObjects;

public record SerialNumber(Guid serialNumber)
{
    public SerialNumber() : this(Guid.NewGuid())
    {
    }

    public override string ToString()
    {
        return serialNumber.ToString();
    }
}