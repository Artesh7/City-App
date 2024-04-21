using CityInfoAPI.Models;

namespace CityInfoAPI.Interfaces;

public interface IDawaService
{
    
    string GetCityNameByZipCode(string zipCode);
    List<Street> GetStreetsByCityZipCode(string zipCode);

}