using GebruikersbeheerZvz.Contexts;
using GebruikersbeheerZvz.Handlers.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GebruikersbeheerZvz.Handlers
{
    // creeer GetRoles handler op basis van mediatr
    public class GetRolesHandler : IRequestHandler<GetRolesQuery, GetRolesQueryResponse>
    {
        private readonly GebruikersbeheerZvzContext _context;

        public GetRolesHandler(GebruikersbeheerZvzContext context)
        {
            _context = context;
        }

        public async Task<GetRolesQueryResponse> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            // haal rollen op uit dbcontext
            var rollen = await _context.Rollen.ToListAsync();

            // return rollen
            return new GetRolesQueryResponse
            {
                Rollen = rollen
            };
        }
    }

}
