using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rbsQuery.Common.Requests;
using rbsQuery.Common.Responses;
using rbsQuery.DataProvider.Interfaces;

namespace rbsQuery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeDataController : ControllerBase
    {
        ITradeDataQuery _tradeDataQuery;
        public TradeDataController(ITradeDataQuery tradeDataQuery)
        {
            _tradeDataQuery = tradeDataQuery;
        }
        [HttpGet]
        public ActionResult<TradeDataResponse> Get(TradeDataRequest request)
        {
            Console.WriteLine("GETTING DATA");
            try
            {
                return _tradeDataQuery.GetTradeData(request);
            }
            catch
            {
            Console.WriteLine("FAILED");
                var response = new TradeDataResponse();
                response.IsSuccess = false;
                response.Message = "Something failed, yo.";
                return response;
            }
        }
    }
}
