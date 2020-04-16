using System.Threading.Tasks;

namespace Covid19Api.Services
{
    public interface IAPIService
    {
        Task<T> CoronaApi<T>();
    }
}