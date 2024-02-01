using Microsoft.EntityFrameworkCore;
using mvc_entity.Models;

namespace api_desafio21dias.Servicos
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
    }
}