using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.PhoneNumberAggregate;
using CleanArchitectureCQRS.Domain.ValueObjects.Addresses;

namespace CleanArchitectureCQRS.Domain.AddressAggregate
{
    public sealed class Address : AggregateRoot<AddressId>
    {
        public Address(
            AddressId Id,
            AddressDetail addressDetail,
            string country,
            PhoneNumber phone)
            : base(Id)
        {
            AddressDetail = addressDetail;
            Country = country;
            PhoneNumber = phone;
        }

        public AddressDetail AddressDetail { get; set; }
        public string Country { get; set; }
        public PhoneNumber PhoneNumber { get; set; }

    }
}
