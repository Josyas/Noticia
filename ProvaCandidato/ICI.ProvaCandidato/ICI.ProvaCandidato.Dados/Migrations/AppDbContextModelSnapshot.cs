﻿// <auto-generated />
using ICI.ProvaCandidato.Dados.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICI.ProvaCandidato.Dados.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .HasMaxLength(8000)
                        .HasColumnType("VARCHAR(8000)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Noticia");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.NoticiaTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdNoticia")
                        .HasColumnType("int");

                    b.Property<int>("IdTag")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdNoticia");

                    b.HasIndex("IdTag");

                    b.ToTable("NoticiaTag");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("Senha")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Noticia", b =>
                {
                    b.HasOne("ICI.ProvaCandidato.Dados.Entities.Usuario", "Usuario")
                        .WithMany("Noticias")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK_Noticia_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.NoticiaTag", b =>
                {
                    b.HasOne("ICI.ProvaCandidato.Dados.Entities.Noticia", "Noticia")
                        .WithMany("NoticiaTags")
                        .HasForeignKey("IdNoticia")
                        .HasConstraintName("FK_NoticiaTag_Noticia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ICI.ProvaCandidato.Dados.Entities.Tag", "Tag")
                        .WithMany("NoticiaTag")
                        .HasForeignKey("IdTag")
                        .HasConstraintName("FK_NoticiaTag_Tag")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Noticia");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Noticia", b =>
                {
                    b.Navigation("NoticiaTags");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Tag", b =>
                {
                    b.Navigation("NoticiaTag");
                });

            modelBuilder.Entity("ICI.ProvaCandidato.Dados.Entities.Usuario", b =>
                {
                    b.Navigation("Noticias");
                });
#pragma warning restore 612, 618
        }
    }
}
