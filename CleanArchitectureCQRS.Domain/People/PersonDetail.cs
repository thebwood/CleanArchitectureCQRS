namespace CleanArchitectureCQRS.Domain.People
{
    public record PersonDetail
    (
        FirstName FirstName,
        LastName LastName,
        DateTime DateOfBirth
    );

}
