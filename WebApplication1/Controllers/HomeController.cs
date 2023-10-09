using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

//1.- AÑADIR LA AUTHORIZACION
using Microsoft.AspNetCore.Authorization;

namespace WebApplication1.Controllers
{
    //2.- AÑADIR LA AUTHORIZACION
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize(Roles = "Administrador,Supervisor,Paciente")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Paciente")]
        public IActionResult Historial() //ventas
        {
            return View();
        }

        [Authorize(Roles = "Paciente, Administrador")]
        public IActionResult Recetas() //compras
        {
            return View();
        }

        [Authorize(Roles = "Paciente")]
        public IActionResult Resultado()  //cliebte
        {
            return View();
        }

        [AllowAnonymous]
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
}