using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using fictional__journey.Models;

namespace fictional__journey.Controllers;

public class HomeController : Controller
{
    private readonly IWebHostEnvironment _environment;

    public HomeController(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        var sampleDataPath = Path.Combine(_environment.ContentRootPath, "sampledata.json");
        var employees = new List<Employee>();

        if (System.IO.File.Exists(sampleDataPath))
        {
            var json = System.IO.File.ReadAllText(sampleDataPath);
            employees = JsonSerializer.Deserialize<List<Employee>>(json) ?? new List<Employee>();
        }

        return View(employees);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
