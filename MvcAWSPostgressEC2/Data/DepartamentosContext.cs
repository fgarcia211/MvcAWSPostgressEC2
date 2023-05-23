using Microsoft.EntityFrameworkCore;
using MvcAWSPostgressEC2.Models;

namespace MvcAWSPostgressEC2.Data
{
    public class DepartamentosContext : DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext> options): base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
