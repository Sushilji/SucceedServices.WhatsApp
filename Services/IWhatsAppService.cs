using SucceedServices.WhatsApp.DTOs;

namespace SucceedServices.WhatsApp.Services;

public interface IWhatsAppService
{
   /// <summary>
    /// Sends a WhatsApp message.
    /// </summary>
    /// <param name="dto">The DTO containing the message details.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task<WhatsAppSendResultDto> SendMessageAsync(WhatsAppMessageDto dto);
}