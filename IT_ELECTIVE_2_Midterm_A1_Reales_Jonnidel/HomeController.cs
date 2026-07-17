using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_Midterm_A1_Reales_Jonnidel.Models;

namespace IT_ELECTIVE_2_Midterm_A1_Reales_Jonnidel.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
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
