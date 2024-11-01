namespace LocalizerTrial.Api.LocalizerTrialResults;

public class ServiceError(string? code, string? message, int statusCode)
{
    public string? Code { get; set; } = code;

    public string? Message { get; set; } = message;

    public int StatusCode { get; set; } = statusCode;
    
    public static ServiceError None => new(null, null, 200);

    public static ServiceError NotFound(string code, string message) => new(code, message, StatusCodes.Status404NotFound);
    
    public static ServiceError InternalServiceError(string code, string message) => new(code, message, StatusCodes.Status500InternalServerError);
    
    public static ServiceError UnprocessableEntity(string code, string message) => new(code, message, StatusCodes.Status422UnprocessableEntity);
    
    public static ServiceError BadRequest(string code, string message) => new(code, message, StatusCodes.Status400BadRequest);
}


