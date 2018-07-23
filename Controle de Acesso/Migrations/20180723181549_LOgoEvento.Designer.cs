﻿// <auto-generated />
using ControleAcesso.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ControleAcesso.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180723181549_LOgoEvento")]
    partial class LOgoEvento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleAcesso.Models.Curso", b =>
                {
                    b.Property<int>("CursoID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao");

                    b.Property<int>("EventoID");

                    b.Property<string>("Nome");

                    b.HasKey("CursoID");

                    b.HasIndex("EventoID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ControleAcesso.Models.Evento", b =>
                {
                    b.Property<int>("EventoID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Descricao");

                    b.Property<string>("Logo");

                    b.Property<string>("Nome");

                    b.HasKey("EventoID");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("ControleAcesso.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Username");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ControleAcesso.Models.Curso", b =>
                {
                    b.HasOne("ControleAcesso.Models.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
