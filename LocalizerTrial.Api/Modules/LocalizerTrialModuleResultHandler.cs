using LocalizerTrial.Api.LocalizerTrialResults;

namespace LocalizerTrial.Api.Modules;

public abstract class LocalizerTrialModuleResultHandler
{
    public static IResult ReturnResultAsJson<TResult>(TResult result)
        where TResult : LocalizerTrialResult
        => Results.Json(result, statusCode: result.GetStatusCode());
}