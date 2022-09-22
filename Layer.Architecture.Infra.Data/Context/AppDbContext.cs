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
        }

        public DbSet<Entrevistado> Entrevistados { get; set; }
        public DbSet<Vaga> vagas { get; set; }
        public DbSet<Tecnologias> Tecnologias { get; set; }
    }
}
