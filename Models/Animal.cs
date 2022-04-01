using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    // [Required]
    public string Name { get; set; }
    // [Required]
    public string Species { get; set; }
  }
}