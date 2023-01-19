using FluentValidation;
using GebruikersbeheerZvz.Handlers.Commands;

namespace GebruikersbeheerZvz.Handlers.Validators
{
    // maak een fluent validator voor de addgebruikercommand
    public class AddGebruikerCommandValidator : AbstractValidator<AddGebruikerCommand>
    {
        public AddGebruikerCommandValidator()
        {
            RuleFor(x => x.Voornaam).NotEmpty().WithMessage("Voornaam is verplicht");
            RuleFor(x => x.Naam).NotEmpty().WithMessage("Naam is verplicht");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is verplicht");
            // creeer rule en controleer dat een emailadres een emailadres is
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email is geen geldig emailadres");
            RuleFor(x => x.Gebruikersnaam).NotEmpty().WithMessage("Gebruikersnaam is verplicht");
            RuleFor(x => x.Rollen).NotEmpty().WithMessage("Rol is verplicht");
        }
    }
}
