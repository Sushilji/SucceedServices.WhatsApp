namespace SucceedServices.WhatsApp.DTOs;

public class WhatsAppResponseDto
{
    public string MessagingProduct { get; set; }
        = string.Empty;

    public List<ContactDto> Contacts { get; set; }
        = [];

    public List<MessageDto> Messages { get; set; }
        = [];
}