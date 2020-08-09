using System.Collections.Generic;
using System.Threading.Tasks;

namespace currency_converter.Repository
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetCurrenciesAsync();

        Task<Currency> GetCurrencyByCharCodeAsync(string charCode);
    }
}