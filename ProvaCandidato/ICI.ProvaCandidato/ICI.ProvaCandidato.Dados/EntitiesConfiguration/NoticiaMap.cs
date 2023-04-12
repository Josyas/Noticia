using ICI.ProvaCandidato.Dados.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICI.ProvaCandidato.Dados.EntitiesConfiguration
{
    public class NoticiaMap : IEntityTypeConfiguration<Noticia>
    {
        public void Configure(EntityTypeBuilder<Noticia> builder)
        {
            builder.ToTable("Noticia");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo)
               .HasColumnType("VARCHAR")
               .HasMaxLength(250);

            builder.Property(x => x.Texto)
               .HasColumnType("VARCHAR");
              
            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Noticias)
                .HasForeignKey(x => x.IdUsuario)
                .HasConstraintName("FK_Noticia_Usuario")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
