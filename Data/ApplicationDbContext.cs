using Microsoft.EntityFrameworkCore;
using SucceedServices.WhatsApp.Models;

namespace SucceedServices.WhatsApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<MessageLog> MessageLogs =>
        Set<MessageLog>();
    public DbSet<WhatsAppSetting> WhatsAppSettings
    => Set<WhatsAppSetting>();
}