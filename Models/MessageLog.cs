namespace SucceedServices.WhatsApp.Models;

public class MessageLog
{
    public int Id { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public bool IsSent { get; set; }

    public DateTime CreatedOn { get; set; }
}