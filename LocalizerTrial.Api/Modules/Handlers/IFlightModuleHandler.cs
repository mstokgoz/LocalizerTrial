using LocalizerTrial.Api.Requests;

namespace LocalizerTrial.Api.Modules.Handlers;

public interface IFlightModuleHandler
{
    Task<IResult> HandleUpdateFlightAsync(Guid id, FlightUpdateRequest request);
}