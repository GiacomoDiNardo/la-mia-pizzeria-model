namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Prezzo { get; set; }

        public Pizza ()
        {

        }

        public Pizza (string name, string description, int prezzo, string image)
        {
            Name = name;
            Description = description;
            Prezzo = prezzo;
            Image = image;
        }
    }
}
