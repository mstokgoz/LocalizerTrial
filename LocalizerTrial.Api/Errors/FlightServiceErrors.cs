using LocalizerTrial.Api.LocalizerTrialResults;
using LocalizerTrial.Api.Services.Test;
using Microsoft.Extensions.Localization;

namespace LocalizerTrial.Api.Errors;

public class FlightServiceErrors
{
    public static ServiceError FlightNotFound(IStringLocalizer<FlightService> localizer,
        string code = nameof(FlightNotFound)) => ServiceError.NotFound(code, localizer[code].Value);

    public static ServiceError WrongFlightDestination(IStringLocalizer<FlightService> localizer,
        string destination, string code = nameof(WrongFlightDestination)) =>
        ServiceError.BadRequest(code, localizer[code, destination].Value);
}