using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.PhoneNumbers;

namespace CleanArchitectureCQRS.Domain.Addresses
{
    public sealed class Address : Entity
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
