using Raven.Client.Documents;

namespace RavenIdConventionSample;

public static class Initializer
{
    public static async Task CreateDatabaseIfNotExists(this IDocumentStore store, string databaseName)
    {
        var databaseExists = await store.Maintenance.Server.SendAsync(
            new Raven.Client.ServerWide.Operations.GetDatabaseRecordOperation(databaseName)) != null;

        if (!databaseExists)
        {
            await store.Maintenance.Server.SendAsync(
                new Raven.Client.ServerWide.Operations.CreateDatabaseOperation(
                    new Raven.Client.ServerWide.DatabaseRecord(databaseName)));
        }
    }
}