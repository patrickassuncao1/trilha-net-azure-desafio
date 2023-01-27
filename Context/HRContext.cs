using Microsoft.EntityFrameworkCore;
using trilha_net_azure_desafio.Models;

namespace trilha_net_azure_desafio.Context
{
    public class HRContext : DbContext
    {

        public HRContext(DbContextOptions<HRContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

    }
}