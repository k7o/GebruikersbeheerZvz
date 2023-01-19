namespace GebruikersbeheerZvz.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Email { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Gebruikersnaam { get; set; }
        public List<Rol> Rollen { get; set; } = new List<Rol>();

        public Gebruiker(string naam, string voornaam, string email, string tussenvoegsel, string gebruikersnaam)
        {
            Naam = naam;
            Voornaam = voornaam;
            Email = email;
            Tussenvoegsel = tussenvoegsel;
            Gebruikersnaam = gebruikersnaam;
        }
    }
}
