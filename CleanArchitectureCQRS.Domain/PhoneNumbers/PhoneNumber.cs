using CleanArchitectureCQRS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.PhoneNumbers
{
    public sealed class PhoneNumber : Entity
    {

        public PhoneNumber(Guid id, CountryCode countryCode, string number, string type) 
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
