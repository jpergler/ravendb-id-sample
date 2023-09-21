using Raven.Client.Documents;
using RavenIdConventionSample;

const string databaseName = "RavenIdConventionSample";
var store = new DocumentStore
{
    Urls = new[] { "http://localhost:8080" },
    Database = databaseName
}.Initialize();

await store.CreateDatabaseIfNotExists(databaseName);

using var session = store.OpenAsyncSession();

var item = Item.New("single word in document type name");
await session.StoreAsync(item);
await session.SaveChangesAsync();

Console.WriteLine($"Item id prefix is '{item.Id.Split('/')[0]}'");

var multiWordItem = MultiWordItem.New("multiple words in document type name");
await session.StoreAsync(multiWordItem);
await session.SaveChangesAsync();

Console.WriteLine($"MultiWordItem id prefix is '{multiWordItem.Id.Split('/')[0]}'");