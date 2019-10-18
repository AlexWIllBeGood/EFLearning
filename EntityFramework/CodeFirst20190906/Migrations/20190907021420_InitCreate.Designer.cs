﻿// <auto-generated />
using CodeFirst20190906;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst20190906.Migrations
{
    [DbContext(typeof(LocalContext))]
    [Migration("20190907021420_InitCreate")]
    partial class InitCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("CodeFirst20190906.Models.ArrangeCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ArrangeCourse");
                });

            modelBuilder.Entity("CodeFirst20190906.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("CodeFirst20190906.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("CodeFirst20190906.Models.ArrangeCourse", b =>
                {
                    b.HasOne("CodeFirst20190906.Models.Student", "student")
                        .WithMany("ArrangeCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeFirst20190906.Models.Teacher", "teacher")
                        .WithMany("ArrangeCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
