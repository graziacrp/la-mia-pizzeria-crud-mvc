namespace La_mia_pizzeria_crud.Models
{
    public class Tag
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public List<Pizza> Pizze { get; set; }


        public Tag() { }
    }
}
