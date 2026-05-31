using SucceedServices.WhatsApp.DTOs;
using SucceedServices.WhatsApp.Models;
using SucceedServices.WhatsApp.Repositories;

namespace SucceedServices.WhatsApp.Services;

public class WhatsAppService : IWhatsAppService
{
    private readonly IMessageLogRepository _repository;

    public WhatsAppService(
        IMessageLogRepository repository)
    {
        _repository = repository;
    }

  
    public async Task<WhatsAppSendResultDto>SendMessageAsync(WhatsAppMessageDto dto)
    {
        MessageLog log = new()
        {
            PhoneNumber = dto.PhoneNumber,
            Message = dto.Message,
            IsSent = true,
            CreatedOn = DateTime.Now
        };

        await _repository.AddAsync(log);

        await _repository.SaveChangesAsync();

        return new WhatsAppSendResultDto
        {
            IsSuccess = true,
            Message = "Message saved successfully"
        };
    }   
}