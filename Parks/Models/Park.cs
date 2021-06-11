using System.ComponentModel.DataAnnotations;
namespace Parks.Models
{
  public class Park
  {
    /// <summary>  
    /// Park id  
    /// </summary> 
    public int ParkId { get; set; }
     [Required]
    public string Name { get; set; }
    [Required]
    [StringLength(12, ErrorMessage = "State has to be at least 2 characters long (WA), but not longer than 12 (Rhode Island)", MinimumLength = 2)]
    public string State {get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "Come on now! A City needs to be at least 3 letters long", MinimumLength = 3)]
    public string City {get; set; }
    [Range(5,5, ErrorMessage = "Zip Code needs to be 5 characters long")]
    public int ZipCode {get; set; }
    [Required]
    public string Type {get; set; }
  }
}