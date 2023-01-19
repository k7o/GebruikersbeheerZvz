using GebruikersbeheerZvz.Handlers.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GebruikersbeheerZvz.Pages
{
    public class AddGebruikerModel : PageModel
    {
        private readonly ISender sender;

        // constructor met isender
        public AddGebruikerModel(ISender sender)
        {
            this.sender = sender ?? throw new ArgumentNullException(nameof(sender));
        }

        [BindProperty]
        public AddGebruikerCommand AddGebruikerCommand { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await sender.Send(AddGebruikerCommand);

            return RedirectToPage("./Index");
        }
    }
}
