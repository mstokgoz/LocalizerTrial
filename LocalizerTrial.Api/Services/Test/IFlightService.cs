using LocalizerTrial.Api.Domain;
using LocalizerTrial.Api.LocalizerTrialResults;
using LocalizerTrial.Api.Requests;

namespace LocalizerTrial.Api.Services.Test;

public interface IFlightService
{
    Task<LocalizerTrialResult<Flight>> UpdateFlightAsync(Guid id, FlightUpdateRequest request);
}