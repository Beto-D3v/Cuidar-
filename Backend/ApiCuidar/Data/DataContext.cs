using ApiCuidar.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCuidar.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Cuidador> Cuidadores{get;set;}
        public DbSet<UsuarioLogin> UsuarioLogins{get;set;}
    }
}