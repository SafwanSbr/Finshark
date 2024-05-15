using api.DTOs;
using api.Interfaces;
using api.Mapper;
using api.Models;
using Newtonsoft.Json;

namespace api.Service
{
    public class FMPService:IFMPService
    {
        private HttpClient _httpClient;
        private IConfiguration _config;

        public FMPService(HttpClient httpClient,IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<Stock?> FindStockBySymbolAsync(string symbol)
        {
            try
            {
                var result = await _httpClient.GetAsync($"https://financialmodelingprep.com/api/v3/profile/{symbol}?apikey={_config["FMPKey"]}");
                
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var tasks = JsonConvert.DeserializeObject<FMPStock[]>(content);
                    var stock = tasks[0];

                    if (stock != null) return stock.toStock();
                    else return null;

                }
                return null;
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
