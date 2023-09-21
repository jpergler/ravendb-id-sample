namespace RavenIdConventionSample;

public class MultiWordItem
{
    public string Id { get; }
    public string Description { get; }

    public MultiWordItem(string id, string description)
    {
        Id = id;
        Description = description;
    }

    public static MultiWordItem New(string description) => new(null!, description);
}