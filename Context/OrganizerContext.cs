using Microsoft.EntityFrameworkCore;

using trilha_net_azure_desafio.Models;

namespace trilha_net_azure_desafio.Context
{
    public class OrganizerContext : DbContext
    {
        public OrganizerContext(DbContextOptions<OrganizerContext> options) : base(options) { }
    }
}