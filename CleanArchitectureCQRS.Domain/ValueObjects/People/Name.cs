using CleanArchitectureCQRS.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRS.Domain.ValueObjects.People
{
    public class Name : ValueObject
    {
        public Name(FirstName firstName, MiddleName middleName, LastName lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public FirstName FirstName { get; private set; }
        public MiddleName MiddleName { get; private set; }
        public LastName LastName { get; private set; }

        public static Name Create(FirstName firstName, MiddleName middleName, LastName lastName)
        {
            return new Name(firstName, middleName, lastName);
        }

        public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";
        public string GetMiddleInitial() => $"{MiddleName.Value[0]}";

        public override IEnumerable<object?> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
