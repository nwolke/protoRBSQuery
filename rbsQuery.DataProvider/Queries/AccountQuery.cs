using rbsQuery.DataProvider.Interfaces;
using rbsQuery.Common.Responses;

namespace rbsQuery.DataProvider.Queries
{
    public class AccountQuery : IAccountQuery
    {
        private IAccountPropertiesQuery _accountPropertiesQuery;

        public AccountQuery(IAccountPropertiesQuery accountPropertiesQuery)
        {
            _accountPropertiesQuery = accountPropertiesQuery;
        }

        public AccountResponse GetAccountData(int accountId, bool includeAccountProperties)
        {
            AccountResponse response = new AccountResponse();
            response.AccountId = accountId;
            if (includeAccountProperties)
            {
                response.AccountPropertiesResponse = _accountPropertiesQuery.GetAccountProperties(accountId);
            }
            return response;
        }

    }
}