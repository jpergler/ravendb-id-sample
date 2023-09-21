namespace RavenIdConventionSample;

public class Item
{
    public string Id { get; }
    public string Description { get; }

    public Item(string id, string description)
    {
        Id = id;
        Description = description;
    }

    public static Item New(string description) => new(null!, description);
}