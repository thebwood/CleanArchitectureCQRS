
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.ValueObjects.Addresses
{
    public record AddressId(Guid Value)
    {
        public static AddressId New() => new(Guid.NewGuid());
    }
}
