using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SCREENSOUND_BASE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCREENSOUND_BASE.Banco
{
    internal class ScreenSoundContext : DbContext
    {

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }


        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSoundV0;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
        }


        /*
        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
        */

    }
}
