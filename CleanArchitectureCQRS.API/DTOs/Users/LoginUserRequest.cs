namespace CleanArchitectureCQRS.API.DTOs.Users
{
    public sealed record LoginUserRequest(string Email, string Password);
}
