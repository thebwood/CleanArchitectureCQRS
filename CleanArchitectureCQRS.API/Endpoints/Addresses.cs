using CleanArchitectureCQRS.Application.Addresses.Commands.Create;
using MediatR;
namespace CleanArchitectureCQRS.API.Endpoints
{
    public class Addresses
    {
        public void AddRoutes(IEndpointRouteBuilder app) {
            app.MapPost("/addresses", async (CreateAddressCommand command, ISender sender) => 
            {
                await sender.Send(command);

                return Results.Ok();
            });
        }
    }
}
