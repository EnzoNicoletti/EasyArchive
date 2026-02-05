using EasyArchive.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EasyArchive.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Configurações adicionais do modelo podem ser feitas aqui
            builder.Entity<Livro>().ToTable("Livros");
            builder.Entity<Aluno>().ToTable("Alunos");
            builder.Entity<Emprestimo>().ToTable("Emprestimos");

        }
    }
}
