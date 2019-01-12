﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TalentsManagerService.Data;

namespace TalentsManagerService.Migrations
{
    [DbContext(typeof(TalentsDbContext))]
    [Migration("20190112040530_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TalentsManagerService.Data.Model.Talent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<bool>("FourToSixHoursPerDay");

                    b.Property<decimal>("HourlySalary");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Name");

                    b.Property<bool>("OnlyWeekends");

                    b.Property<string>("Phone");

                    b.Property<string>("Portfolio");

                    b.Property<bool>("SixToHeightHoursPerDay");

                    b.Property<string>("Skype");

                    b.Property<string>("State");

                    b.Property<bool>("UpToEightHoursPerDay");

                    b.Property<bool>("UpToFourHoursPerDay");

                    b.Property<bool>("WorkingAfternoon");

                    b.Property<bool>("WorkingBusiness");

                    b.Property<bool>("WorkingDawn");

                    b.Property<bool>("WorkingMorning");

                    b.Property<bool>("WorkingNight");

                    b.Property<string>("_skills")
                        .HasColumnName("SkillsCollection");

                    b.HasKey("Id");

                    b.ToTable("Talents");

                    b.HasData(
                        new { Id = 1L, City = "Campinas", CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "lmhofling@gmail.com", FourToSixHoursPerDay = false, HourlySalary = 85m, LastUpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Linkedin = "https =//www.linkedin.com/in/leonardo-miranda-hofling-126b0320/", Name = "Leonardo", OnlyWeekends = false, Phone = "+551900000000", Portfolio = "xxx", SixToHeightHoursPerDay = false, Skype = "leonardo.hofling", State = "São Paulo", UpToEightHoursPerDay = false, UpToFourHoursPerDay = true, WorkingAfternoon = false, WorkingBusiness = false, WorkingDawn = true, WorkingMorning = false, WorkingNight = true, _skills = "C#;Java" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}