using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewBag_MVC.Models;

namespace ViewBag_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {

        _logger = logger;
    }

    public IActionResult Index()
    {

        // ViewBag, ViewData dan farkı, ViewData object taşıyabilirken, ViewBag dynamic tipi taşıyabilir!!
        //Viewbag, arka planda ViewData kullanmaktadır!!

        // ViewBag ile bir veri taşıyalım!!
        ViewBag.Student = new Ogrenci()
        {

            Age = 10,
            Id = 1,
            Name = "Özgür"
        };

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
