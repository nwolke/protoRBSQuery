using System;
using System.Net.Http;
using Newtonsoft.Json;
using rbsQuery.Common.Requests;
using rbsQuery.Common.Responses;

namespace rbsQuery.Common
{
    public static class RESTCaller
    {
        public static async System.Threading.Tasks.Task<string> GetDataAsync(TradeDataRequest request)
        {
            string baseUrl = "http://localhost:5005/api/TradeData";

            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage{
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(baseUrl),
                    Content = new StringContent(JsonConvert.SerializeObject(request))
                };
                using (HttpResponseMessage res = await client.SendAsync(httpRequest))
                {
                    using (HttpContent content = res.Content)
                    {
                        var data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            var deserialized = JsonConvert.DeserializeObject<TradeDataResponse>(data);
                            Console.WriteLine(deserialized);
                            return "success! " + data;
                        }
                    }
                }
            }
            return "failed";
        }
    }

}