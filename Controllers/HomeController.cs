using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Yummy.WebUI.Models;

namespace Yummy.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
