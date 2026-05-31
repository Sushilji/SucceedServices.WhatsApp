using SucceedServices.WhatsApp.Data;
using SucceedServices.WhatsApp.Models;
using SucceedServices.WhatsApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SucceedServices.WhatsApp.Repositories;

public class MessageLogRepository : IMessageLogRepository
{
    private readonly ApplicationDbContext _context;

    public MessageLogRepository(
        ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        MessageLog messageLog)
    {
        await _context.MessageLogs.AddAsync(
            messageLog);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<List<MessageLog>> GetAllAsync()
    {
        return await _context.MessageLogs
            .OrderByDescending(x => x.Id)
            .ToListAsync();
    }
}
