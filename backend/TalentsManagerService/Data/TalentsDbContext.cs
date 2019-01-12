using Microsoft.EntityFrameworkCore;
using System;
using TalentsManagerService.Data.Model;

namespace TalentsManagerService.Data
{
    public class TalentsDbContext : DbContext
    {
        #region Properties

        public DbSet<Talent> Talents { get; set; }

        #endregion

        public TalentsDbContext(DbContextOptions<TalentsDbContext> options)
        : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talent>().HasData(
                new Talent {
                    Id = 1,
                    Name = "Leonardo",
                    Email = "lmhofling@gmail.com",
                    Skype = "leonardo.hofling",
                    Phone = "+551900000000",
                    Linkedin = "https =//www.linkedin.com/in/leonardo-miranda-hofling-126b0320/",
                    City = "Campinas",
                    State = "São Paulo",
                    Portfolio = "xxx",
                    UpToFourHoursPerDay = true,
                    FourToSixHoursPerDay = false,
                    SixToHeightHoursPerDay = false,
                    UpToEightHoursPerDay = false,
                    OnlyWeekends = false,
                    WorkingMorning = false,
                    WorkingAfternoon = false,
                    WorkingDawn = true,
                    WorkingNight = true,
                    WorkingBusiness = false,
                    HourlySalary = 85m,
                    _skills = "C#;Java"
                }
            );
        }
    }
}
