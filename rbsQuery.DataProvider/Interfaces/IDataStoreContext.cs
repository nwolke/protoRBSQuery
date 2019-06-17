namespace rbsQuery.DataProvider.Interfaces
{
    public interface IDataStoreContext
    {
        string CreateConnectionString(string enterpriseid, string clientid);
    }
}