﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracticaMuchosAMuchos.Data;

#nullable disable

namespace PracticaMuchosAMuchos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250108170108_PracticaMuchosAMuchosStudentsCourses")]
    partial class PracticaMuchosAMuchosStudentsCourses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PracticaMuchosAMuchos.Models.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("PracticaMuchosAMuchos.Models.StudentCourses", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentsStudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CoursesCourseId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("PracticaMuchosAMuchos.Models.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("PracticaMuchosAMuchos.Models.StudentCourses", b =>
                {
                    b.HasOne("PracticaMuchosAMuchos.Models.Courses", null)
                        .WithMany("StudentCourses")
                        .HasForeignKey("CoursesCourseId");

                    b.HasOne("PracticaMuchosAMuchos.Models.Students", null)
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentsStudentId");
                });

            modelBuilder.Entity("PracticaMuchosAMuchos.Models.Courses", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("PracticaMuchosAMuchos.Models.Students", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
