using CityInfoAPI.Interfaces;
using CityInfoAPI.Models;

namespace CityInfoAPI.Services;

public class DawaService : IDawaService
{
    private readonly HttpClient _httpClient;
    public DawaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public string GetCityNameByZipCode(string zipCode)
    {
        throw new NotImplementedException();
    }

    public List<Street> GetStreetsByCityZipCode(string zipCode)
    {
        throw new NotImplementedException();
    }
}