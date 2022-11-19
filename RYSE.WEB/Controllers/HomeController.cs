using Microsoft.AspNetCore.Mvc;
using RYSE.WEB.Models;
using System.Diagnostics;

namespace RYSE.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> cliente = new List<Cliente>()
            {

                new Cliente
                {
                    IDCedula = 1,
                    FirstName = "Leonys",
                    LastName = "Vasquez",
                    FechaNacimiento = DateTime.Now,
                    Usuario = "Leonys14",
                    Email = "leonysasquez@gmail.com",
                    Contraseña = "LEONYSV14",
                    Direccion = "Cacique Calle Turey RD, S.D. DN",
                    EnrollmentDate = DateTime.Now,
                    Discreminator ="L"
                },

                new Cliente
                {
                    IDCedula = 2,
                    FirstName = "Jose",
                    LastName = "Guerrero",
                    FechaNacimiento = DateTime.Now,
                    Usuario = "Jose14",
                    Email = "joseguerrero@gmail.com",
                    Contraseña = "jose14",
                    Direccion = "Cacique Calle Turey RD, S.D. DN",
                    EnrollmentDate = DateTime.Now,
                    Discreminator = "j"
                },




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
}