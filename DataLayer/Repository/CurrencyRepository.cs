using currency_converter.DAL;
using currency_converter.Network;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace currency_converter.Repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly IApiService _apiService;

        public CurrencyRepository(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync()
        {
            List<Currency> currencies = new List<Currency>();

            using (var db = new CurrencyContext())
            {
                currencies = db.Currencies.ToList();

                if (currencies.Count == 0)
                {
                    Response response = await _apiService.GetResponseAsync();
                    foreach (var v in response.Valute.Values)
                    {
                        currencies.Add(new Currency(v.CharCode, v.Nominal, v.Name, v.Value, response.Date.UtcDateTime));
                    }

                    db.SaveChanges();

                    return currencies;
                }

                for (int i = 0; i < currencies.Count; i++)
                {
                    Currency c = currencies[i];
                    TimeSpan interval = DateTime.Now - c.LastUpdate;
                    if (interval > TimeSpan.FromDays(1) && c.CharCode != "RUB")
                    {
                        currencies[i] = await UpdateCurrency(c.CharCode, db);
                    }
                }
            }

            return currencies;
        }

        public async Task<Currency> GetCurrencyByCharCodeAsync(string charCode)
        {
            Currency currency;

            using (var db = new CurrencyContext())
            {
                currency = db.Currencies.Where(c => c.CharCode.Equals(charCode)).FirstOrDefault();

                if (charCode == "RUB") return currency;

                if (currency == null)
                {
                    currency = await LoadCurrencyToDb(charCode, db);
                }
                else
                {
                    TimeSpan interval = DateTime.Now - currency.LastUpdate;
                    if (interval > TimeSpan.FromDays(1))
                    {
                        currency = await UpdateCurrency(charCode, db);
                    }
                }
            }

            return currency;
        }

        private async Task<Currency> UpdateCurrency(string charCode, CurrencyContext context)
        {
            Currency currency;

            currency = context.Currencies.Where(c => c.CharCode.Equals(charCode)).First();

            Response response = await _apiService.GetResponseAsync();

            response.Valute.TryGetValue(charCode, out ValuteResponse valuteResponse);

            currency.Value = valuteResponse.Value;
            currency.LastUpdate = response.Date.UtcDateTime;

            context.Entry(currency).State = EntityState.Modified;

            context.SaveChanges();

            return currency;
        }

        private async Task<Currency> LoadCurrencyToDb(string charCode, CurrencyContext context)
        {
            Currency currency;

            Response response = await _apiService.GetResponseAsync();

            response.Valute.TryGetValue(charCode, out ValuteResponse valuteResponse);

            currency = new Currency(valuteResponse.CharCode, valuteResponse.Nominal, valuteResponse.Name, valuteResponse.Value, response.Date.UtcDateTime);
            
            context.Currencies.Add(currency);

            context.SaveChanges();

            return currency;
        }
    }
}