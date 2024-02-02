using api_desafio21dias.Models;
using Microsoft.EntityFrameworkCore;

namespace api_desafio21dias.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}