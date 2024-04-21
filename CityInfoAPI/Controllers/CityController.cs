using CityInfoAPI.DTOs;
using CityInfoAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoAPI.Controllers;

public class CityController : ControllerBase
{
    private readonly IDawaService _dawaService;
    private readonly IWikipediaService _wikipediaService;
    
    public CityController(IDawaService dawaService, IWikipediaService wikipediaService)
    {
        _dawaService = dawaService;
        _wikipediaService = wikipediaService;
    }
    
    [HttpGet("api/city/{zipCode}")]
    public async Task<IActionResult> GetCityInfo(CityRequestDto cityRequestDto)
    {
        // var cityName = _dawaService.GetCityNameByZipCode(zipCode);
        // var cityDescription = _wikipediaService.GetCityDescriptionByCityName(cityName);
        
        return Ok("Works");
    }
}