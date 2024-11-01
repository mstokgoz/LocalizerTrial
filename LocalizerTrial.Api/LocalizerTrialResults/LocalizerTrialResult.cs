namespace LocalizerTrial.Api.LocalizerTrialResults;

public class LocalizerTrialResult<T>(
    T data,
    string? message,
    bool isSuccess,
    ServiceError? serviceError,
    int statusCode) : LocalizerTrialResult(message, isSuccess, serviceError, statusCode)
{
    public T Data { get; set; } = data;

    public static LocalizerTrialResult<T> Success(T data, string? message = null, int? statusCode = null) =>
        new(data, message, true, ServiceError.None, statusCode ?? 200);

    public new static LocalizerTrialResult<T> Fail(ServiceError serviceError, T? data = default) =>
        new(data, serviceError.Message, false, serviceError, serviceError.StatusCode);
}

public class LocalizerTrialResult(string? message, bool isSuccess, ServiceError? serviceError, int statusCode)
{
    public bool IsSuccess { get; set; } = isSuccess;
    public string? Message { get; set; } = message;

    private ServiceError? ServiceError { get; set; } = serviceError;

    private int StatusCode { get; set; } = statusCode;

    public static LocalizerTrialResult Success(string? message = null, int? statusCode = null) =>
        new(message, true, ServiceError.None, statusCode ?? 200);

    public static LocalizerTrialResult Fail(ServiceError serviceError) =>
        new(serviceError.Message, false, serviceError, serviceError.StatusCode);
    
    public int GetStatusCode() => StatusCode;
    
}