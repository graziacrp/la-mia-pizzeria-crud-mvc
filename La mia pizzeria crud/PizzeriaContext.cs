using La_mia_pizzeria_crud.Models;
using System.Collections.Generic;

namespace La_mia_pizzeria_crud
{
    public class PizzeriaContext: DbContext
    {
        public DbSet<Pizza> Pizze { get; set; }
        public DbSet<Category> Categorie { get; set; }
        public DbSet<Ingredienti> Ingredienti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzeria;Integrated Security=True");
        }
    }
}
}
