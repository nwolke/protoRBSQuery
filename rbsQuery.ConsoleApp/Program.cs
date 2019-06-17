using System;
using rbsQuery.Common;
using rbsQuery.Common.Requests;

namespace rbsQuery.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeDataRequest = new TradeDataRequest();
            tradeDataRequest.ForEnterprise(1).ForClient(1).ForAccounts(new int[]{1,4});
            Console.WriteLine(RESTCaller.GetDataAsync(tradeDataRequest).GetAwaiter().GetResult());
        }
    }
}
