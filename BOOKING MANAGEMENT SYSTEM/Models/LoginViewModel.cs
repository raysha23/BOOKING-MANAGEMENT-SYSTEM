using System.ComponentModel.DataAnnotations;

namespace BOOKING_MANAGEMENT_SYSTEM.Models
{
  public class LoginViewModel
  {
    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }
  }
}
