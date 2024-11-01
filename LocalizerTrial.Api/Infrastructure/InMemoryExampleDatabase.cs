using LocalizerTrial.Api.Domain;

namespace LocalizerTrial.Api.Infrastructure;

public class InMemoryExampleDatabase
{
    public static async Task<Flight?> GetFlightByIdAsync(Guid id)
    {
        await Task.Delay(100);

        return id == Guid.Parse("916ed1b7-2ff0-4bfe-97aa-eb0a990e46a9") ? Flight.Instance(id, "London") : null;
    }
}