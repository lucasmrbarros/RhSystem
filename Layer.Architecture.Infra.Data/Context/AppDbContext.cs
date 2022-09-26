using Layer.Architecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Layer.Architecture.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Entrevistado>()
               .HasOne(entrevistado => entrevistado.Vaga)
               .WithMany(vaga => vaga.Entrevistados)
               .HasForeignKey(entrevistado => entrevistado.VagaId);

            builder.Entity<VagaNNTecnologias>()
                .HasOne(vagaNNTecnologias => vagaNNTecnologias.Tecnologias)
                .WithMany(tecnologias => tecnologias.vagas)
                .HasForeignKey(vagaNNTecnologias => vagaNNTecnologias.TecId);

            builder.Entity<VagaNNTecnologias>()
                .HasOne(vagaNNTecnologias => vagaNNTecnologias.Vaga)
                .WithMany(vaga => vaga.Tecnologias)
                .HasForeignKey(vagaNNTecnologias => vagaNNTecnologias.VagaId);

            builder.Entity<EntrevistadoNNTecnologias>()
            .HasOne(entrevistadoNNTecnologia => entrevistadoNNTecnologia.Tecnologias)
            .WithMany(Tecnologias => Tecnologias.entrevistados)
            .HasForeignKey(entrevistadoNNTecnologia => entrevistadoNNTecnologia.TecId);

            builder.Entity<EntrevistadoNNTecnologias>()
               .HasOne(entrevistadoNNTecnologia => entrevistadoNNTecnologia.Entrevistado)
               .WithMany(entrevistado => entrevistado.Tecnologias)
               .HasForeignKey(entrevistadoNNTecnologia => entrevistadoNNTecnologia.EntrevistadoId);

        }

        public DbSet<Entrevistado> Entrevistados { get; set; }
        public DbSet<Vaga> vagas { get; set; }
        public DbSet<Tecnologias> Tecnologias { get; set; }
        public DbSet<VagaNNTecnologias> vagaNNTecnologias { get; set; }
        public DbSet<EntrevistadoNNTecnologias> entrevistadoNNTecnologias { get; set; }
    }
}
