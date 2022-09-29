using Layer.Architecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Layer.Architecture.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
<<<<<<< Updated upstream
         builder.Entity<Entrevistado>()
            .HasOne(entrevistado => entrevistado.Vaga)
            .WithMany(vaga => vaga.Entrevistados)
            .HasForeignKey(entrevistado => entrevistado.VagaId);
=======
            //Relacionamentro 1:n Entrevistados e vagas
            builder.Entity<Entrevistado>()
               .HasOne(entrevistado => entrevistado.Vaga)
               .WithMany(vaga => vaga.Entrevistados)
               .HasForeignKey(entrevistado => entrevistado.VagaId);

            //Relacionamento n:n entrevistados e tencologias
            builder.Entity<VagaNNTecnologias>()
                .HasOne(vagaNNTecnologias => vagaNNTecnologias.Tecnologias)
                .WithMany(tecnologias => tecnologias.vagas)
                .HasForeignKey(vagaNNTecnologias => vagaNNTecnologias.TecId);

            builder.Entity<VagaNNTecnologias>()
                .HasOne(vagaNNTecnologias => vagaNNTecnologias.Vaga)
                .WithMany(vaga => vaga.Tecnologias)
                .HasForeignKey(vagaNNTecnologias => vagaNNTecnologias.VagaId);

            //Relacionamento n:n vagas e tencologias
            builder.Entity<EntrevistadoNNTecnologias>()
            .HasOne(entrevistadoNNTecnologia => entrevistadoNNTecnologia.Tecnologias)
            .WithMany(Tecnologias => Tecnologias.entrevistados)
            .HasForeignKey(entrevistadoNNTecnologia => entrevistadoNNTecnologia.TecId);

            builder.Entity<EntrevistadoNNTecnologias>()
               .HasOne(entrevistadoNNTecnologia => entrevistadoNNTecnologia.Entrevistado)
               .WithMany(entrevistado => entrevistado.Tecnologias)
               .HasForeignKey(entrevistadoNNTecnologia => entrevistadoNNTecnologia.EntrevistadoId);

>>>>>>> Stashed changes
        }

        public DbSet<Entrevistado> Entrevistados { get; set; }
        public DbSet<Vaga> vagas { get; set; }
        public DbSet<Tecnologias> Tecnologias { get; set; }
    }
}
