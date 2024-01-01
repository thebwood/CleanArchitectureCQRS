using CleanArchitectureCQRS.Domain.Addresses;
using MediatR;

namespace CleanArchitectureCQRS.Application.Addresses.Commands.Create
{
    public class CreateAddressCommand : IRequestHandler<CreateAddressCommand>
    {
        IAddressRepository _addressRepository;

        public CreateAddressCommand(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
