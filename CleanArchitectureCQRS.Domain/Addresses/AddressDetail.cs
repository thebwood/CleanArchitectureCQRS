namespace CleanArchitectureCQRS.Domain.Addresses
{
    public record AddressDetail(
        string Street,
        string Number,
        string City,
        string State,
        string ZipCode
    );
}
