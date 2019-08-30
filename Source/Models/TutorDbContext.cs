using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TutorTime.Models
{
    public class TutoringRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPeople { get; set; }
        public string Problem { get; set; }
        public DateTimeOffset DateTime { get; set; }
    }
    public class Tutor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }

        public virtual IList<TutoringRequest> TutoringRequests { get; set; }

    }
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