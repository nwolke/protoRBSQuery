using rbsQuery.DataProvider.Interfaces;
using rbsQuery.Common.Requests;
using rbsQuery.Common.Responses;
using System.Collections.Generic;

namespace rbsQuery.DataProvider.Queries
{
    public class TradeDataQuery : ITradeDataQuery
    {
        IAccountQuery _accountQuery;
        public TradeDataQuery(IAccountQuery accountQuery)
        {
            _accountQuery = accountQuery;
        }

        public TradeDataResponse GetTradeData(TradeDataRequest request)
        {
            TradeDataResponse response = new TradeDataResponse();
            List<AccountResponse> accountresponses = new List<AccountResponse>();
            foreach (var accountid in request.AccountSet.AccountIds)
            {
                accountresponses.Add(_accountQuery.GetAccountData(accountid, request.AccountSet.includeAccountProperties));
            }
            return response;
        }
    }
}