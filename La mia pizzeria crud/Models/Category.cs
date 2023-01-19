using System.ComponentModel.DataAnnotations;

namespace La_mia_pizzeria_crud.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public List<Pizza> Pizze { get; set; }

        public Category()
        {

        }
    }
}

