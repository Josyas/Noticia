using ICI.ProvaCandidato.Dados.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICI.ProvaCandidato.Dados.EntitiesConfiguration
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
               .HasColumnType("VARCHAR")
               .HasMaxLength(250);
        }
    }
}
