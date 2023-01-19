using GebruikersbeheerZvz.Models;

namespace GebruikersbeheerZvz.Handlers.Queries
{
    // response op getrolesquery met rollen
    public class GetRolesQueryResponse
    {
        public IEnumerable<Rol> Rollen { get; set; }
    }
}
