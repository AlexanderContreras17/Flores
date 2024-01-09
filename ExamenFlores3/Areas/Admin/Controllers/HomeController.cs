using ExamenFlores3.Areas.Admin.Models;
using ExamenFlores3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExamenFlores3.Areas.Admin.Controllers
{
    [Area("Admin")]
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
    }
}
