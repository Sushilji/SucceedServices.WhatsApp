namespace SucceedServices.WhatsApp.DTOs;

public class WhatsAppRequestDto
{
    public string MessagingProduct { get; set; }
        = "whatsapp";

    public string To { get; set; }
        = string.Empty;

    public string Type { get; set; }
        = "text";

    public WhatsAppTextDto Text { get; set; }
        = new();
}