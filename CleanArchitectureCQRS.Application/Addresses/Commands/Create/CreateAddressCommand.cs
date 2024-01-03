using CleanArchitectureCQRS.Domain.Abstractions.Repositories;
using MediatR;

namespace CleanArchitectureCQRS.Application.Addresses.Commands.Create
{
    public class CreateAddressCommand : IRequestHandler<CreateAddressCommandHandler>
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
