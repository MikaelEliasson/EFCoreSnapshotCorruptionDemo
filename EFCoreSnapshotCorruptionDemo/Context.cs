using Microsoft.EntityFrameworkCore;

namespace EFCoreSnapshotCorruptionDemo
{
    public class Context : DbContext
    {
        public DbSet<Blogpost> Blogposts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\;Initial Catalog=ef-corruption-demo;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
