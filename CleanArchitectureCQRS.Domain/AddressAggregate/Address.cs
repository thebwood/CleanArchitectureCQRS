using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.Addresses;
using CleanArchitectureCQRS.Domain.PhoneNumberAggregate;

namespace CleanArchitectureCQRS.Domain.AddressAggregate
{
    public sealed class Address : AggregateRoot
    {
        public Address(
            Guid Id,
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
