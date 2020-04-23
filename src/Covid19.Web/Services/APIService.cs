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
    public class APIService : IAPIService
    {
        public HttpClient Client { get; private set; }
        public APIService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.covid19api.com");
            Client = httpClient;
        }

        public async Task<T> GetSummary<T>()
        {
            string url = "https://api.covid19api.com/summary";
            
            var result = await Client.GetStringAsync(url);
            var DeserializeObject = JsonConvert.DeserializeObject<T>(result);

            return DeserializeObject;
        }

        
        public async Task<T> GetCountry<T>()
        {
            string url = "https://api.covid19api.com/countries";

            var result = await Client.GetStringAsync(url);
            var DeserializeObject = JsonConvert.DeserializeObject<T>(result);

            return DeserializeObject;
        }



    }
}




