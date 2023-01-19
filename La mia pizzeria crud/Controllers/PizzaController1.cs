using Microsoft.AspNetCore.Mvc;

namespace La_mia_pizzeria_crud.Controllers
{
    public class PizzaController1 : Controller
    {
        private readonly ILogger<PizzaController1> _logger;

        public PizzaController1(ILogger<PizzaController1> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PizzeriaContext context = new PizzeriaContext();
            return View(context.Pizze.Include(p => p.Categoria).ToList());
        }
    }
}
