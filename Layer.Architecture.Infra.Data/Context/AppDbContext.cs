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
            //Relacao entre Empresa e vagas (1:n)
            builder.Entity<Vaga>()
                .HasOne(vaga => vaga.Empresa)
                .WithMany(empresa => empresa.Vagas)
                .HasForeignKey(vaga => vaga.EmpresaId);

            //Relacao entre Entrevistado e Tecnologias(1:n)
            builder.Entity<Tecnologias>()
                .HasOne(tencologias => tencologias.Entrevistado)
                .WithMany(entrevistados => entrevistados.Tecnologias)
                .HasForeignKey(tecnologias => tecnologias.EntrevistadoId);

            //Relacao entre vaga e tecnologia(1:n)
            builder.Entity<Tecnologias>()
                .HasOne(tecnologias => tecnologias.Vaga)
                .WithMany(vaga => vaga.Tecnologias)
                .HasForeignKey(tecnologias => tecnologias.VagaId);

            //Relacao Cadidato Vaga (1:n)
            builder.Entity<Vaga>()
                .HasOne(vaga => vaga.Entrevistado)
                .WithMany(entrevistados => entrevistados.Vagas)
                .HasForeignKey(vaga => vaga.EntrevistadoId); ;
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Entrevistado> Entrevistados { get; set; }
        public DbSet<Vaga> vagas { get; set; }
        public DbSet<Tecnologias> Tecnologias { get; set; }
    }
}
