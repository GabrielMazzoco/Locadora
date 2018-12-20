﻿// <auto-generated />
using System;
using LocadoraApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocadoraApp.Migrations
{
    [DbContext(typeof(LocadoraAppContext))]
    [Migration("20181218170217_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocadoraApp.Entities.Diretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Diretores");
                });

            modelBuilder.Entity("LocadoraApp.Entities.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataLancamento");

                    b.Property<int>("DiretorId");

                    b.Property<int>("GeneroId");

                    b.Property<string>("Name");

                    b.Property<string>("Sinopse");

                    b.HasKey("Id");

                    b.HasIndex("DiretorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("LocadoraApp.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("LocadoraApp.Entities.Filme", b =>
                {
                    b.HasOne("LocadoraApp.Entities.Diretor", "Diretor")
                        .WithMany("Filmes")
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LocadoraApp.Entities.Genero", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}