    using Microsoft.EntityFrameworkCore;

namespace TutorTime.Models
{
    public class TutorDbContext : DbContext
    {
        public TutorDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<TutoringRequest> TutoringRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tutor>(e => e.HasMany(p => p.TutoringRequests));

            base.OnModelCreating(modelBuilder);
        }
    }
}