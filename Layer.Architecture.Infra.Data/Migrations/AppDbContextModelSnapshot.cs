// <auto-generated />
using Layer.Architecture.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Layer.Architecture.Infra.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Entrevistado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<int>("VagaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VagaId");

                    b.ToTable("Entrevistados");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Tecnologias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tecnologias");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("vagas");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Entrevistado", b =>
                {
                    b.HasOne("Layer.Architecture.Domain.Models.Vaga", "Vaga")
                        .WithMany("Entrevistados")
                        .HasForeignKey("VagaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("Layer.Architecture.Domain.Models.Vaga", b =>
                {
                    b.Navigation("Entrevistados");
                });
#pragma warning restore 612, 618
        }
    }
}
