using Microsoft.AspNetCore.Mvc;
using SucceedServices.WhatsApp.DTOs;
using SucceedServices.WhatsApp.Models;
using SucceedServices.WhatsApp.Repositories;
using SucceedServices.WhatsApp.Services;

namespace SucceedServices.WhatsApp.Controllers;

public class WhatsAppController : Controller
{
    private readonly IWhatsAppService _whatsAppService;
    private readonly IMessageLogRepository _repository;

    public WhatsAppController(
        IWhatsAppService whatsAppService,
        IMessageLogRepository repository)
    {
        _whatsAppService = whatsAppService;
        _repository = repository;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new WhatsAppMessageModel());
    }

    [HttpPost]
    public async Task<IActionResult> Index(
        WhatsAppMessageModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var dto = new WhatsAppMessageDto
        {
            PhoneNumber = model.PhoneNumber,
            Message = model.Message
        };

        var sendResult =
            await _whatsAppService.SendMessageAsync(dto);

        ViewBag.Status = sendResult.Message;

        ModelState.Clear();

        return View(new WhatsAppMessageModel());
    }

    [HttpGet]
    public async Task<IActionResult> Logs()
    {
        var logs = await _repository.GetAllAsync();

        return View(logs);
    }

    [HttpGet]
    public async Task<IActionResult> Dashboard()
    {
        var logs = await _repository.GetAllAsync();

        DashboardViewModel model = new()
        {
            TotalMessages = logs.Count,
            SuccessfulMessages = logs.Count(x => x.IsSent),
            FailedMessages = logs.Count(x => !x.IsSent),
            TodayMessages = logs.Count(
                x => x.CreatedOn.Date == DateTime.Today)
        };

        return View(model);
    }
}