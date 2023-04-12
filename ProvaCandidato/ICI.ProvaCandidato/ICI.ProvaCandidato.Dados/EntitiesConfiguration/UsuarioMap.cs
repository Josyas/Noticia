using ICI.ProvaCandidato.Dados.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ICI.ProvaCandidato.Dados.EntitiesConfiguration
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
               .HasColumnType("VARCHAR")
               .HasMaxLength(250);

            builder.Property(x => x.Senha)
               .HasColumnType("VARCHAR")
               .HasMaxLength(250);

            builder.Property(x => x.Email)
               .HasColumnType("VARCHAR")
               .HasMaxLength(250);
        }
    }
}
