using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using currency_converter.Network;

namespace currency_converter.Repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly IApiService _apiService;
        private List<Currency> _currencies;

        public CurrencyRepository(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync()
        {
            if (_currencies == null)
            {
                await Load();
            }

            return _currencies;
        }

        public async Task<Currency> GetCurrencyByCharCodeAsync(string charCode)
        {
            if (_currencies == null)
            {
                await Load();
            }

            return _currencies.Find(c => c.CharCode == charCode);
        }

        private async Task Load()
        {
            var response = await _apiService.GetResponseAsync();
            _currencies = response.Valute.Values.Select(valuteResponse => new Currency(valuteResponse)).ToList();
            _currencies.Add(GetRuble());
        }

        private Currency GetRuble()
        {
            return new Currency("RUB", 1, "Российский рубль", 1);
        }
    }
}