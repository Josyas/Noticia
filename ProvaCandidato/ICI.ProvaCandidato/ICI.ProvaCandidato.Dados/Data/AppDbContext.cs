using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Dados.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ICI.ProvaCandidato.Dados.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NoticiaTag> NoticiaTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseSqlServer(@"Data Source=localhost;Initial Catalog=ICITeste;User ID=sa;Password=mt43jq704590;TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new NoticiaMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new NoticiaTagMap());
        }
    }
}
