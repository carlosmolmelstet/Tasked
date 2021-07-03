using Microsoft.EntityFrameworkCore;
using System;
using Tasked.Shared.Data;

namespace Tasked.Server.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Work> Works { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Work>()
               .Property(e => e.Id).ValueGeneratedOnAdd().IsRequired();

            modelBuilder.Entity<Work>()
               .Property(e => e.Name).HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Work>()
               .Property(e => e.Effort).IsRequired();

            modelBuilder.Entity<Work>()
                .HasData(
                    new Work { Id = Guid.NewGuid(), Name = "Tarefa 1", Effort = 5 },
                    new Work { Id = Guid.NewGuid(), Name = "Tarefa 2", Effort = 1 },
                    new Work { Id = Guid.NewGuid(), Name = "Tarefa 3", Effort = 10 }
                );


           
        }
    }
}
