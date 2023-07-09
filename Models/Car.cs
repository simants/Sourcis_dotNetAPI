using System.ComponentModel.DataAnnotations;

namespace Sourcis_dotNetAPI.Models;

public class Car{

    public int Id { get; set;}
    // To remove nullable warning we use [Required].
    [Required]
    public string Make { get; set;} = string.Empty; 
    [Required]
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
}