using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RockVault.Models;

namespace RockVault.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Catalogo()
    {
        var bandas = CatalogoData.ObtenerBandas();
        return View(bandas);
    }

    public IActionResult Detalle(int id)
    {
        var banda = CatalogoData.ObtenerPorId(id);

        if (banda is null)
        {
            return NotFound();
        }

        return View(banda);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
