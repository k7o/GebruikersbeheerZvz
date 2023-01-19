using GebruikersbeheerZvz.Contexts;
using GebruikersbeheerZvz.Handlers.Commands;
using GebruikersbeheerZvz.Models;
using MediatR;

namespace GebruikersbeheerZvz.Handlers
{
    // creeer AddGebruikerHandler als Mediatr request handler
    public class AddGebruikerHandler : IRequestHandler<AddGebruikerCommand>
    {
        private readonly GebruikersbeheerZvzContext _context;

        public AddGebruikerHandler(GebruikersbeheerZvzContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddGebruikerCommand request, CancellationToken cancellationToken)
        {
            // creer Gebruiker op basis van AddGebruikerCommand via constructor
            var gebruiker = new Gebruiker(
                request.Voornaam, 
                request.Tussenvoegsel, 
                request.Naam, 
                request.Email, 
                request.Gebruikersnaam);


            // voeg gebruiker toe aan dbcontext
            _context.Gebruikers.Add(gebruiker);

            // sla wijzigingen op in db
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
