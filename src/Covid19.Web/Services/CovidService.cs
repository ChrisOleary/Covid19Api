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
    public class CovidService : ICovidService
    {
        public HttpClient Client { get; private set; }
        public CovidService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.covid19api.com");
            Client = httpClient;
        }

        public async Task<ApiRootObject> GetSummary<ApiRootObject>()
        {
            string url = "https://api.covid19api.com/summary";
            
            var result = await Client.GetStringAsync(url);
            var DeserializeObject = JsonConvert.DeserializeObject<ApiRootObject>(result);

            return DeserializeObject;
        }

        
        public async Task<Countries> GetCountry<Countries>()
        {
            string url = "https://api.covid19api.com/countries";

            var result = await Client.GetStringAsync(url);
            var DeserializeObject = JsonConvert.DeserializeObject<Countries>(result);

            return DeserializeObject;
        }



    }
}




