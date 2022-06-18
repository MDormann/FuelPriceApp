var fuelPriceApi = new FuelPrice.Api.FuelPriceApiClient("00000000-0000-0000-0000-000000000002");

var result = await fuelPriceApi.GetPetrolStationsByRadiusAsync(50.908663313159266, 8.007591612121427, 1.5);

foreach (var petrolStation in result)
{
    Console.WriteLine($"Tankstelle: {petrolStation.Name}, Benzinpreis: {petrolStation.E5}");
}