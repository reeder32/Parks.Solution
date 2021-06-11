using System.ComponentModel.DataAnnotations;
namespace Parks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
     [StringLength(10)]
    public string Name { get; set; }
    [Required]
    [Range(2, 12, ErrorMessage = "State has to be at least 2 characters long (WA), but not longer than 12 (Rhode Island)")]
    public string State {get; set; }
    [Required]
    [Range(3, 20, ErrorMessage = "Come on now! A City needs to be at least 3 letters long")]
    public string City {get; set; }
    [Required]
    [Range(5, 5, ErrorMessage = "Zip Code must be 5 characters long")]
    public int ZipCode {get; set; }
    [Required]
    public string Type {get; set; }
  }
}