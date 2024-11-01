using LocalizerTrial.Api.Requests;
using LocalizerTrial.Api.Services.Test;

namespace LocalizerTrial.Api.Modules.Handlers;

public class FlightModuleHandler(IFlightService flightService) : IFlightModuleHandler
{
    public async Task<IResult> HandleUpdateFlightAsync(Guid id, FlightUpdateRequest request)
        => LocalizerTrialModuleResultHandler.ReturnResultAsJson(await flightService.UpdateFlightAsync(id, request));
}