using CleanArchitectureCQRS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.Common.ValueObjects
{
    public class BirthDate : ValueObject
    {
        public BirthDate(DateTime value)
        {
            Value = value;
        }

        public DateTime Value { get; private set; }

        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - Value.Year;
            if (Value.Date > today.AddYears(-age)) age--;
            return age;
        }

        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
