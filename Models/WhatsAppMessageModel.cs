using System.ComponentModel.DataAnnotations;

namespace SucceedServices.WhatsApp.Models;

public class WhatsAppMessageModel
{
    [Required]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    [StringLength(1000)]
    public string Message { get; set; } = string.Empty;
}