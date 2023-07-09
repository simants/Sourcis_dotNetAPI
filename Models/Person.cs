using System.ComponentModel.DataAnnotations;

namespace Sourcis_dotNetAPI.Models;

public class Person{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Gender { get; set; } = string.Empty;
    public int Age { get; set; }
}