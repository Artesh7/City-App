namespace CityInfoAPI.Interfaces;

public interface IWikipediaService
{
    string GetCityDescriptionByCityName(string cityName);
    
}