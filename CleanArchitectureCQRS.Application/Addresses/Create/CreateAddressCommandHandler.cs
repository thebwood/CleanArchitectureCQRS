using CleanArchitectureCQRS.Application.Abstractions;
using CleanArchitectureCQRS.Domain.Addresses;
using CleanArchitectureCQRS.Domain.Repositories;
using MediatR;

namespace CleanArchitectureCQRS.Application.Addresses.Create
{
    internal class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateAddressCommandHandler(IAddressRepository addressRepository, IUnitOfWork unitOfWork)
        {
            _addressRepository = addressRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            Address address = new()
            {
                Id = Guid.NewGuid(),
                Street = request.Street,
                Number = request.Number,
                City = request.City,
                State = request.State,
                PostalCode = request.PostalCode,
                Country = request.Country,
                Phone = request.Phone
            };


            _addressRepository.Add(address);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
