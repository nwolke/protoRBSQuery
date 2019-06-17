using rbsQuery.Common.Responses;
using rbsQuery.Common.Requests;

namespace rbsQuery.DataProvider.Interfaces
{
    public interface IAccountQuery
    {
        AccountResponse GetAccountData(int accountid, bool includeAccountProperties);
    }
}