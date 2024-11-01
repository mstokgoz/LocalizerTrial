using LocalizerTrial.Api.Domain;
using LocalizerTrial.Api.Errors;
using LocalizerTrial.Api.Infrastructure;
using LocalizerTrial.Api.LocalizerTrialResults;
using LocalizerTrial.Api.Requests;
using Microsoft.Extensions.Localization;

namespace LocalizerTrial.Api.Services.Test;

public class FlightService(IStringLocalizer<FlightService> localizer) : IFlightService
{
    public async Task<LocalizerTrialResult<Flight>> UpdateFlightAsync(Guid id, FlightUpdateRequest request)
    {
        var flight = await InMemoryExampleDatabase.GetFlightByIdAsync(id);

        if (flight is null)
            return LocalizerTrialResult<Flight>.Fail(FlightServiceErrors.FlightNotFound(localizer));

        if (IsFlightDestinationValid(request.Destination))
            return LocalizerTrialResult<Flight>.Fail(
                FlightServiceErrors.WrongFlightDestination(localizer, request.Destination));

        flight.UpdateDestination(request.Destination);
        
        return LocalizerTrialResult<Flight>.Success(flight);
    }


    private static bool IsFlightDestinationValid(string destination) => destination.Length > 3;
}