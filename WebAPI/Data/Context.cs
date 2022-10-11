using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Data
{
    public class Context : DbContext // informando que a api vai se comunicar com o banco (DbContext)
    {
        public Context (DbContextOptions<Context> options):base(options)
        {
            
        }
        public DbSet<Clientes> Clientes { get; set; }

    }
}
