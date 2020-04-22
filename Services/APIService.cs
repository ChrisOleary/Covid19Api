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
        public async Task<T> GetSummary<T>()
        {
            string url = "https://api.covid19api.com/summary";
            var client = new HttpClient();
            var result = await client.GetStringAsync(url);
            var DeserializeObject = JsonConvert.DeserializeObject<T>(result);

            return DeserializeObject;
        }

    }
}
