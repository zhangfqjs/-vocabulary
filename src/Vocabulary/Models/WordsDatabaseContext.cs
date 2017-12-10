using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Vocabulary.Models
{
    public class WordsDatabaseContext : DbContext
    {
        public WordsDatabaseContext(DbContextOptions<WordsDatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MyWord> MyWords { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}