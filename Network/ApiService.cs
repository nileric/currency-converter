using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace currency_converter.Network
{
    public class ApiService : IApiService
    {
        private readonly string _url = "https://www.cbr-xml-daily.ru/daily_json.js";
        public async Task<Response> GetResponseAsync()
        {
            var webRequest = WebRequest.Create(_url) as HttpWebRequest;
            if (webRequest == null)
            {
                return null;
            }
            webRequest.ContentType = "application/json";
            
            var response = new Response();

            using (var webResponse = await webRequest.GetResponseAsync())
            {
                using (var responseStream = webResponse.GetResponseStream())
                {
                    using (var streamReader = new StreamReader(responseStream))
                    {
                        var json = await streamReader.ReadToEndAsync();
                        response = JsonConvert.DeserializeObject<Response>(json);
                    }
                }
            }

            return response;
        }
    }
}