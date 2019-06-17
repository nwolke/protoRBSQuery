using rbsQuery.Common.Requests;
using rbsQuery.Common.Responses;

namespace rbsQuery.DataProvider.Interfaces
{
    public interface ITradeDataQuery
    {
        TradeDataResponse GetTradeData(TradeDataRequest request);
    }

}