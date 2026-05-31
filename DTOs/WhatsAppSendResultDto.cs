namespace SucceedServices.WhatsApp.DTOs;

public class WhatsAppSendResultDto
{
    public bool IsSuccess { get; set; }

    public string Message { get; set; }
        = string.Empty;

    public string? MetaMessageId { get; set; }
}