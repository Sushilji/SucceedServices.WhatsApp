using Microsoft.AspNetCore.Mvc;

namespace SucceedServices.WhatsApp.Controllers;

public class SettingsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}