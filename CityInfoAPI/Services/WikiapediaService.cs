using CityInfoAPI.Interfaces;

namespace CityInfoAPI.Services;

public class WikiapediaService : IWikipediaService
{
    private readonly HttpClient _httpClient;
    public WikiapediaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    
    public string GetCityDescriptionByCityName(string cityName)
    {
        throw new NotImplementedException();
    }
}