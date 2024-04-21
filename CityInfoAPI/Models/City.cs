namespace CityInfoAPI.Models;

public class City
{
    public String Name { get; set; }
    public List<Street> Streets { get; set; }
    public String Description { get; set; }
    public String ZipCode { get; set; }
}