namespace CleanArchitectureCQRS.Domain.ValueObjects.PhoneNumbers
{
    public record PhoneNumberId(Guid Value)
    {
        public static PhoneNumberId New() => new(Guid.NewGuid());
    }
}
