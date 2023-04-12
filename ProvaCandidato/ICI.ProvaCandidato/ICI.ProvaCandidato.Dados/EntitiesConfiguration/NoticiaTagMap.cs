using ICI.ProvaCandidato.Dados.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICI.ProvaCandidato.Dados.EntitiesConfiguration
{
    public class NoticiaTagMap : IEntityTypeConfiguration<NoticiaTag>
    {
        public void Configure(EntityTypeBuilder<NoticiaTag> builder)
        {
            builder.ToTable("NoticiaTag");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Tag)
                .WithMany(x => x.NoticiaTag)
                .HasForeignKey(x => x.IdTag)
                .HasConstraintName("FK_NoticiaTag_Tag")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Noticia)
                .WithMany(x => x.NoticiaTags)
                .HasForeignKey(x => x.IdNoticia)
                .HasConstraintName("FK_NoticiaTag_Noticia")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
