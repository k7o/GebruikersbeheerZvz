using GebruikersbeheerZvz.Models;
using Microsoft.EntityFrameworkCore;

namespace GebruikersbeheerZvz.Contexts
{
    // creeer dbcontext voor gebruiker en rol
    public class GebruikersbeheerZvzContext : DbContext
    {
        public GebruikersbeheerZvzContext(DbContextOptions<GebruikersbeheerZvzContext> options)
           : base(options)
        {
        }

        // voeg een property toe voor de gebruikers
        public DbSet<Gebruiker> Gebruikers { get; set; }

        // voeg een property toe voor de rollen
        public DbSet<Rol> Rollen { get; set; }

        // voeg een property toe voor de categorieen
        public DbSet<Categorie> Categorieen { get; set; }

        // voeg een property toe voor de categorieenrollen
        public DbSet<CategorieRol> CategorieenRollen { get; set; }
    }
}
