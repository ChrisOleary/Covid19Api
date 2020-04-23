using Covid19Api.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Covid19Api.Services
{
    public class APIService
    {
        // added this
        public HttpClient Client { get; private set; }
        public APIService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.covid19api.com/summary");
            Client = httpClient;
        }
        // ! added this

        public async Task<ApiRootObject> GetSummary()
        {
            string url = "https://api.covid19api.com/summary";
            
            var result = await Client.GetStringAsync(url);
            var DeserializeObject = JsonConvert.DeserializeObject<ApiRootObject>(result);

            return DeserializeObject;
        }

    }
}
