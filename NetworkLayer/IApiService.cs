using System.Threading.Tasks;

namespace currency_converter.Network
{
    public interface IApiService
    {
        Task<Response> GetResponseAsync();

        Task<ValuteResponse> GetValuteResponseAsync(string charCode);
    }
}