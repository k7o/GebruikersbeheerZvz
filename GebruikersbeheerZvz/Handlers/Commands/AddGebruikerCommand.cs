using GebruikersbeheerZvz.Handlers.Validator;
using MediatR;

namespace GebruikersbeheerZvz.Handlers.Commands
{
    public class AddGebruikerCommand : IRequest<Unit>, ICommand<Unit>
    {
        public string? Voornaam { get; set; }
        public string? Tussenvoegsel { get; set; }
        public string? Naam { get; set; }
        public string? Email { get; set; }
        public string? Gebruikersnaam { get; set; }
        public List<int> Rollen { get; set; } = new List<int>();
    }
}
