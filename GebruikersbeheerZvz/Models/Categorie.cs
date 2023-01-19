namespace GebruikersbeheerZvz.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        // lijst met rollen
        public List<Rol> Rollen { get; set; } = new List<Rol>();

        public Categorie(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
