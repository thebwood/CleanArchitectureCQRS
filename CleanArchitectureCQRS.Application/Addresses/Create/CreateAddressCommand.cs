using MediatR;
namespace CleanArchitectureCQRS.Application.Addresses.Create
{
    public record CreateAddressCommand(string Street, string Number, string City, string State, string PostalCode, string Country, string Phone) : IRequest
    {
    }
}
