using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_mia_pizzeria_crud.Models
{
    public class Ingredienti
    {
        [Table("ingredienti")]
        public class Ingrediente
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            public LinkedList<Pizza> Pizzas { get; set; }

            public Ingrediente()
            {

            }
        }
    }
}
