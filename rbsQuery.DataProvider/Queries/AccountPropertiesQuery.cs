using rbsQuery.Common.Responses;
using rbsQuery.DataProvider.Interfaces;

namespace rbsQuery.DataProvider.Queries
{
    public class AccountPropertiesQuery : IAccountPropertiesQuery
    {
        IDataStoreContext _dataStoreContext;
        public AccountPropertiesQuery(IDataStoreContext dataStoreContext)
        {
            _dataStoreContext = dataStoreContext;
        }
        public AccountPropertiesResponse GetAccountProperties(int accountid)
        {
            throw new System.NotImplementedException();
        }
    }
}