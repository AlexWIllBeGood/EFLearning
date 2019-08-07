﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _20190730EFCoreProgram.Context;

namespace _20190730EFCoreProgram.Migrations
{
    [DbContext(typeof(LocalContext))]
    partial class LocalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("_20190730EFCoreProgram.Models.ArrangeCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CName")
                        .HasMaxLength(300);

                    b.Property<string>("EName")
                        .HasMaxLength(300);

                    b.Property<int>("StudentId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ArrangeCourse");
                });

            modelBuilder.Entity("_20190730EFCoreProgram.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CName");

                    b.Property<string>("EName");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CName = "佚名",
                            EName = "Alex"
                        });
                });

            modelBuilder.Entity("_20190730EFCoreProgram.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CName");

                    b.Property<int>("EName");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("_20190730EFCoreProgram.Models.ArrangeCourse", b =>
                {
                    b.HasOne("_20190730EFCoreProgram.Models.Student", "Student")
                        .WithMany("ArrangeCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_20190730EFCoreProgram.Models.Teacher", "Teacher")
                        .WithMany("ArrangeCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
