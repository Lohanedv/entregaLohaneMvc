using Microsoft.EntityFrameworkCore;

namespace entregaLohane.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
            
        }
        public DbSet<Destino> destinos { get; set; }    
        public DbSet<Contato> contatos { get; set; }        
    }
}
