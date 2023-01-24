using Microsoft.AspNetCore.Mvc;

namespace La_mia_pizzeria_crud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Home");
        }
        public IActionResult Menu()
        {

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewData["pizzaId"] = id;

            return View("PizzaDetails");
        }

    }
}

