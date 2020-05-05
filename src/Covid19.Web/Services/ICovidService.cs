using System.Threading.Tasks;

namespace Covid19Api.Services
{
    public interface ICovidService
    {
        Task<ApiRootObject> GetSummary<ApiRootObject>();
        Task<Countries> GetCountry<Countries>();
    }
}