using System.ComponentModel.DataAnnotations;
namespace Parks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
     [StringLength(10)]
    public string Name { get; set; }
    [Required]
    public string State {get; set; }
    [Required]
    public string City {get; set; }
    public int ZipCode {get; set; }
    [Required]
    public string Type {get; set; }
  }
}