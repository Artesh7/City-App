using System.ComponentModel.DataAnnotations;

namespace CityInfoAPI.DTOs;

public class CityRequestDto
{
    [Required(ErrorMessage = "ZipCode is required.")]
    [RegularExpression("^[0-9]{4}$", ErrorMessage = "ZipCode must be exactly 4 digits.")]
    public String ZipCode { get; set; }
}