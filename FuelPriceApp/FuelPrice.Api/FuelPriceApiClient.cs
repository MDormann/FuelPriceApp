using FuelPrice.Api.Models;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace FuelPrice.Api
{
    public class FuelPriceApiClient
    {
        private HttpClient _client { get; set; }
        private string _apiKey;

        public FuelPriceApiClient(string apiKey)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://creativecommons.tankerkoenig.de");
            _apiKey = apiKey;
        }

        public async Task<List<PetrolStation>> GetPetrolStationsByRadiusAsync(double lat, double lng, double radius)
        {
            var uri = $"json/list.php?lat={lat.ToString(CultureInfo.InvariantCulture)}&lng={lng.ToString(CultureInfo.InvariantCulture)}&rad={radius.ToString(CultureInfo.InvariantCulture)}&sort=dist&type=all&apikey={_apiKey}";
            var response = await _client.GetAsync(uri);

            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();

                var apiResponse = JsonSerializer.Deserialize<ApiResponse>(result, new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
                });

                if(apiResponse != null && apiResponse.Ok)
                {
                    return apiResponse.Stations;
                }
            }

            return new List<PetrolStation>();
        }
    }
}

//50.908663313159266, 8.007591612121427
//https://creativecommons.tankerkoenig.de/json/list.php?lat=52.521&lng=13.438&rad=1.5&sort=dist&type=all&apikey=00000000-0000-0000-0000-000000000002