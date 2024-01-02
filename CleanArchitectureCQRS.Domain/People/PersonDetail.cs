using CleanArchitectureCQRS.Domain.Common.ValueObjects;

namespace CleanArchitectureCQRS.Domain.People
{
    public record PersonDetail
    (
        Name Name,
        BirthDate DateOfBirth
    );

}
