namespace SucceedServices.WhatsApp.DTOs;

public class WhatsAppSettingsDto
{
    public string AccessToken { get; set; }
        = string.Empty;

    public string PhoneNumberId { get; set; }
        = string.Empty;

    public string BusinessAccountId { get; set; }
        = string.Empty;

    public string VerifyToken { get; set; }
        = string.Empty;
}
