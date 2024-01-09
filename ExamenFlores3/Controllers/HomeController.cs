using ExamenFlores3.Repositories;
using Microsoft.AspNetCore.Mvc;
using ExamenFlores3.Models.ViewModel;

namespace ExamenFlores3.Controllers
{
    public class HomeController : Controller
    {
        private readonly FloresRepository floresRepo;

        public HomeController(FloresRepository floresRepo)
        {
            this.floresRepo = floresRepo;
        }

        public IActionResult Index()
        {
            var vm = floresRepo.GetAll().Select(flor => new IndexViewModel
            {
                Id = flor.Id,
                Nombre = flor.NombreFlor
            });

            return View(vm);
        }

        
        [HttpGet("/Home/Detalles/{id}")]
        public IActionResult Detalles()
        {
            return View();
        }
 
    }

}
