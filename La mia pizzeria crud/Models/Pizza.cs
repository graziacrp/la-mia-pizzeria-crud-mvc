using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace La_mia_pizzeria_crud.Models
{
    
        [Table("Pizze")]
        public class Pizza
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Il campo è obbligatorio")]
            [StringLength(25, ErrorMessage = "Nome troppo lungo")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Il campo è obbligatorio")]
            public string Description { get; set; }

            public string? Img { get; set; }

            [Required(ErrorMessage = "Il campo è obbligatorio")]
            public decimal Price { get; set; }

            public int? CategoryId { get; set; }
            public Category? Category { get; set; }

            //public List<Ingrediente> Ingredienti { get; set; }

            public Pizza()
            {

            }
            public Pizza(int id, string name, string description, string img, decimal price)
            {
                Id = id;
                Name = name;
                Description = description;
                Img = img;
                Price = price;
            }
        }
    }

