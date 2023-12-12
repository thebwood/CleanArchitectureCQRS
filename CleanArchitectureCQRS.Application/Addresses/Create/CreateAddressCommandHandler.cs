using MediatR;

namespace CleanArchitectureCQRS.Application.Addresses.Create
{
    internal class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand>
    {
        public Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
