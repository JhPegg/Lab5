using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Data
{
    public class AnswerImageDataContext : DbContext
    {
        public AnswerImageDataContext(DbContextOptions<AnswerImageDataContext> options) : base(options)
        {
        }

        public DbSet<AnswerImages> AnswerImage { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerImages>().ToTable("AnswerImages");


        }
    }
}
