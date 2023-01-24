using La_mia_pizzeria_crud.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace La_mia_pizzeria_crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        private readonly PizzeriaContext _db = new PizzeriaContext();

        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public IActionResult SendMessage([FromBody] Message message)
        {

            _db.Messages.Add(message);
            _db.SaveChanges();

            return Ok(new { message = "sended" });
        }

      

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Message message)
        {

        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
    

