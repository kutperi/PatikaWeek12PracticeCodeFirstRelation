using Microsoft.EntityFrameworkCore;
using PatikaWeek12PracticeCodeFirstRelation.Entities;

namespace PatikaWeek12PracticeCodeFirstRelation.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Post> Posts => Set<Post>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=KUTPERI\SQLEXPRESS; Database=PatikaCodeFirstDb2; Trusted_Connection=true; TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            // Describing relations between User and Post

            modelBuilder.Entity<User>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
