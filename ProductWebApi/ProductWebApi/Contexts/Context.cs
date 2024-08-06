
using Microsoft.EntityFrameworkCore;
using ProductWebApi.Domains;

namespace ProductWebApi.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Products> Products  { get; set; }



        /// <summary>
        /// Define as opções de construção do banco
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string de conexao local SSMS
             optionsBuilder.UseSqlServer("Server=NOTE19-SALA19; Database=Product_MT; pwd=Senai@134;User Id =sa; TrustServerCertificate=true;");

            // optionsBuilder.UseSqlServer("MATHEUSLIMA\\SQLEX; Database=Product_MT; pwd=Senai@134;User Id =sa; TrustServerCertificate=true;");

            //String de conexao sql database- Azure
            // optionsBuilder.UseSqlServer("Server = tcp:eventmatheus-server.database.windows.net,1433; Initial Catalog = eventMatheusDatabase; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;User Id = eventmatheus-server; Pwd=Senai@134;");


            base.OnConfiguring(optionsBuilder);
        }

    }
}
