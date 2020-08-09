using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace currency_converter.Network
{
    public interface IApiService
    {
        Task<Response> GetResponseAsync();
    }
}