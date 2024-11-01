namespace LocalizerTrial.Api.Domain;

public class Flight
{
    public Guid Id { get; set; }
    
    public string Destination { get; set; }
    
    public static Flight Instance(Guid id, string destination)
    {
        return new Flight
        {
            Id = id,
            Destination = destination
        };
    }
    
    public void UpdateDestination(string destination)
    {
        Destination = destination;
    }
}