using CleanArchitectureCQRS.Domain.ValueObjects.People;

namespace CleanArchitectureCQRS.Domain.People
{
    public record PersonDetail
    (
        Name Name,
        BirthDate DateOfBirth
    );

}
