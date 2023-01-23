using La_mia_pizzeria_crud.Database;
using La_mia_pizzeria_crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace La_mia_pizzeria_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        [HttpGet]
public IActionResult Get()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> pizze = db.Pizze.Include(pizza => pizza.Tags).ToList<pizze>();

                return Ok(pizze);
            }
        }
    }
}
