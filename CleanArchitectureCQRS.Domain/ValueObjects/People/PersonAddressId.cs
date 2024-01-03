
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.ValueObjects.People
{
    public record PersonAddressId(Guid Value)
    {
        public static PersonAddressId New() => new(Guid.NewGuid());
    }
}
