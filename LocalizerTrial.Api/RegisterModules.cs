namespace LocalizerTrial.Api;

public static class RegisterModules
{
    public static IEndpointRouteBuilder RegisterEndpoints(this IEndpointRouteBuilder app)
    {
        // var rememberPasswordGroup = app.MapGroup("/remember-password");
        //
        // rememberPasswordGroup.MapPost("/check-grant-type",
        //     async ([FromServices] IFlightService testService) 
        //         => await testService.TestMethodAsync());
        //
        //
        return app;
    }    
}