
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.ValueObjects.People
{
    public record PersonId(Guid Value)
    {
        public static PersonId New() => new(Guid.NewGuid());
    }
}
