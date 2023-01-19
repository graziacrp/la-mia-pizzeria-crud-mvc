using Microsoft.AspNetCore.Mvc;

namespace La_mia_pizzeria_crud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
