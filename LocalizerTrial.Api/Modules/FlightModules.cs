using LocalizerTrial.Api.Modules.Handlers;
using LocalizerTrial.Api.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LocalizerTrial.Api.Modules;

public static class FlightModules
{
    public static IEndpointRouteBuilder RegisterFlightEndpoints(this IEndpointRouteBuilder app)
    {
        var flightGroup = app.MapGroup("/flights");

        flightGroup.MapPut("/{id:guid}",
            async ([FromRoute] Guid id,
                    [FromBody] FlightUpdateRequest request,
                    [FromServices] IFlightModuleHandler flightModuleHandler)
                => await flightModuleHandler.HandleUpdateFlightAsync(id, request));

        return app;
    }
}