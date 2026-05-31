namespace SucceedServices.WhatsApp.Models;

public class DashboardViewModel
{
    public int TotalMessages { get; set; }

    public int SuccessfulMessages { get; set; }

    public int FailedMessages { get; set; }

    public int TodayMessages { get; set; }
}