﻿// <auto-generated />
using Layer.Architecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Layer.Architecture.Infra.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220920143501_BigOne")]
    partial class BigOne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Entrevistado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Pontos")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Entrevistados");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Tecnologias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EntrevistadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntrevistadoId");

                    b.HasIndex("VagaId");

                    b.ToTable("Tecnologias");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("EntrevistadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EntrevistadoId");

                    b.ToTable("vagas");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Tecnologias", b =>
                {
                    b.HasOne("Layer.Architecture.Domain.Models.Entrevistado", "Entrevistado")
                        .WithMany("Tecnologias")
                        .HasForeignKey("EntrevistadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Layer.Architecture.Domain.Models.Vaga", "Vaga")
                        .WithMany("Tecnologias")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrevistado");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Vaga", b =>
                {
                    b.HasOne("Layer.Architecture.Domain.Models.Empresa", "Empresa")
                        .WithMany("Vagas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Layer.Architecture.Domain.Models.Entrevistado", "Entrevistado")
                        .WithMany("Vagas")
                        .HasForeignKey("EntrevistadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Entrevistado");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Empresa", b =>
                {
                    b.Navigation("Vagas");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Entrevistado", b =>
                {
                    b.Navigation("Tecnologias");

                    b.Navigation("Vagas");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Vaga", b =>
                {
                    b.Navigation("Tecnologias");
                });
#pragma warning restore 612, 618
        }
    }
}