using La_mia_pizzeria_crud.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace La_mia_pizzeria_crud.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PizzeriaContext context = new PizzeriaContext();
            return View(context.Pizze.Include(p => p.Category).ToList());
        }
    }
}
