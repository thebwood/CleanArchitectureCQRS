using CleanArchitectureCQRS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Common.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(FirstName firstName, LastName lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public FirstName FirstName { get; private set;  }
        public LastName LastName { get; private set; }

        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
