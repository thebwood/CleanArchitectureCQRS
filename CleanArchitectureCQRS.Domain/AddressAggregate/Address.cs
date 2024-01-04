using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Addresses.Events;
using CleanArchitectureCQRS.Domain.PhoneNumberAggregate;
using CleanArchitectureCQRS.Domain.ValueObjects.Addresses;
using CleanArchitectureCQRS.Domain.ValueObjects.Users;
using System.Diagnostics.Metrics;

namespace CleanArchitectureCQRS.Domain.AddressAggregate
{
    public sealed class Address : AggregateRoot<AddressId>
    {
        public Address(
            AddressId Id,
            AddressDetail addressDetail,
            PhoneNumber phone)
            : base(Id)
        {
            AddressDetail = addressDetail;
            PhoneNumber = phone;
        }

        public AddressDetail AddressDetail { get; set; }
        public PhoneNumber PhoneNumber { get; set; }

        public static Address Create(AddressDetail addressDetail, PhoneNumber phone)
        {

            Address address = new Address(AddressId.New(), addressDetail, phone);

            address.AddDomainEvent(new AddressCreateDomainEvent(address.Id));

            return address;
        }



    }
}
