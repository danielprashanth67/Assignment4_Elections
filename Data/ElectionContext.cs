using Assignment4_Elections.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment4_Elections.Data
{
    public class ElectionContext : DbContext
    {
        public ElectionContext(DbContextOptions<ElectionContext> options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Committee> Committees { get; set; }
        public DbSet<Filing> Filings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>().ToTable("Candidate");
            modelBuilder.Entity<Committee>().ToTable("Committee");
            modelBuilder.Entity<Filing>().ToTable("Filing");
        }
    }
}