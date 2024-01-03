using CleanArchitectureCQRS.Domain.Abstractions;
using CleanArchitectureCQRS.Domain.PhoneNumbers;
using CleanArchitectureCQRS.Domain.ValueObjects.PhoneNumbers;

namespace CleanArchitectureCQRS.Domain.PhoneNumberAggregate
{
    public sealed class PhoneNumber : AggregateRoot<PhoneNumberId>
    {

        public PhoneNumber(PhoneNumberId id, CountryCode countryCode, string number, string type)
            : base(id)
        {
            CountryCode = countryCode;
            Number = number;
            Type = type;
        }
        public CountryCode CountryCode { get; private set; }

        public string Number { get; private set; } = string.Empty;
        public string Type { get; private set; } = string.Empty;

    }
}
