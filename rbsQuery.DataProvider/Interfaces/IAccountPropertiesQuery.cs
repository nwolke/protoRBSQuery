using rbsQuery.Common.Responses;

namespace rbsQuery.DataProvider.Interfaces
{
    public interface IAccountPropertiesQuery
    {
        AccountPropertiesResponse GetAccountProperties(int accountid);
    }
}