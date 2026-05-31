using SucceedServices.WhatsApp.Models;

namespace SucceedServices.WhatsApp.Repositories;

public interface IMessageLogRepository
{
    Task AddAsync(MessageLog messageLog);

    Task <List<MessageLog>> GetAllAsync();

    Task SaveChangesAsync();
    
}