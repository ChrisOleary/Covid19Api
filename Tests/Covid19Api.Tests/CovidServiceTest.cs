using Covid19Api.Models;
using System;
using Xunit;
using Shouldly;
using RichardSzalay.MockHttp;
using Covid19Api.Services;
using System.Threading.Tasks;

namespace Covid19Api.Tests
{
    public class CovidServiceTest
    {
        [Fact]
        public async Task return_newconfirmed_single_value()
        {
            var mockHttp = new MockHttpMessageHandler();

            //setup mock test
            mockHttp.When("https://api.covid19api.com/summary")
                .Respond("application/json", "{ 'Global': { 'NewConfirmed': '100'}} "); // respond with 100

            var client = mockHttp.ToHttpClient();

            var apiservice = new CovidService(client);
            var user = await apiservice.GetSummary<ApiRootObject>();

            user.Global.NewConfirmed.ShouldBe(100);
        }

        [Fact]
        public async Task return_single_country()
        {
            var mockHttp = new MockHttpMessageHandler();

            //setup mock test
            mockHttp.When("https://api.covid19api.com/countries")
                .Respond("application/json", "{ 'Country': 'Barbados'} "); // respond with Barbados

            var client = mockHttp.ToHttpClient();

            var apiservice = new CovidService(client);
            var user = await apiservice.GetCountry<SingleCountry>();

            user.Country.ShouldBe("Barbados");
        }


    }
}
