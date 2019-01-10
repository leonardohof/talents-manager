using Microsoft.EntityFrameworkCore;
using System;
using TalentsManagerService.Data.Model;

namespace TalentsManagerService.Data
{
    public class TalentsDbContext : DbContext
    {
        #region Properties

        public DbSet<Talent> Talents { get; set; }
        public DbSet<Knowledge> Knowledges { get; set; }
        public DbSet<TalentKnowledge> TalentKnowledges { get; set; }

        #endregion

        public TalentsDbContext(DbContextOptions<TalentsDbContext> options)
        : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knowledge>().HasData(
                new Knowledge { Id = 1, Name = "Ionic", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 2, Name = "Android", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 3, Name = "iOS", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 4, Name = "HTML", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 5, Name = "CSS", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 6, Name = "Bootstrap", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 7, Name = "jQuery", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 8, Name = "AngularJs", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 9, Name = "Java", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now },
                new Knowledge { Id = 10, Name = "ASP .NET MVC", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now }
            );
        }
    }
}
