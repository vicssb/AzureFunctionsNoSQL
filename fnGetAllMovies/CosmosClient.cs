
internal class CosmosClient
{
    private string? connectionString;

    public CosmosClient(string? connectionString)
    {
        this.connectionString = connectionString;
    }

    internal object GetContainer(string v1, string v2)
    {
        throw new NotImplementedException();
    }
}