using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    // herdar o contexto do entity framework do  banco de dados  com : DbContext (precisa adicionar a referencia do dbcontext também)
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
