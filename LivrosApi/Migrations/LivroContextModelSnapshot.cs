﻿// <auto-generated />
using System;
using LivrosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Livros.Api.Migrations
{
    [DbContext(typeof(LivroContext))]
    partial class LivroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Livros.Api.Models.Comentario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("PublicacaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PublicacaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Livros.Api.Models.Publicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("Reacao")
                        .HasColumnType("int");

                    b.Property<string>("Resenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Publicacoes");
                });

            modelBuilder.Entity("LivrosApi.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Autor")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QtdePagina")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("LivrosApi.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("LivrosApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDeNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Livros.Api.Models.Comentario", b =>
                {
                    b.HasOne("Livros.Api.Models.Publicacao", null)
                        .WithMany("Comentario")
                        .HasForeignKey("PublicacaoId");

                    b.HasOne("LivrosApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Api.Models.Publicacao", b =>
                {
                    b.HasOne("LivrosApi.Models.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivrosApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LivrosApi.Models.Livro", b =>
                {
                    b.HasOne("LivrosApi.Models.Usuario", null)
                        .WithMany("Livro")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("LivrosApi.Models.Login", b =>
                {
                    b.HasOne("LivrosApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Livros.Api.Models.Publicacao", b =>
                {
                    b.Navigation("Comentario");
                });

            modelBuilder.Entity("LivrosApi.Models.Usuario", b =>
                {
                    b.Navigation("Livro");
                });
#pragma warning restore 612, 618
        }
    }
}
