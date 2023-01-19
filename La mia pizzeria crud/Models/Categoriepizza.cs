using Microsoft.AspNetCore.Mvc.Rendering;

namespace La_mia_pizzeria_crud.Models
{
    public class Categoriepizza
    {
        public Pizza Pizza { get; set; }
        public List<Category>? Categorie { get; set; }

        public List<SelectListItem>? Ingredienti { get; set; }
        public List<string> IngredientiScelti { get; set; }
    }
}

