using GebruikersbeheerZvz.Models;
using MediatR;

namespace GebruikersbeheerZvz.Handlers.Queries
{
    public class GetRolesQuery : IRequest<GetRolesQueryResponse>
    {
        public int Id { get; set; }
    }
}
