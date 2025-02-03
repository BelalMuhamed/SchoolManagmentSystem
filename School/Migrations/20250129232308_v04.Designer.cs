﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Modules;

#nullable disable

namespace School.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20250129232308_v04")]
    partial class v04
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("School.Modules.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("varchar");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("classId")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("classId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("School.Modules.user", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("varchar");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.HasKey("ClassID");

                    b.HasIndex("ManagerId")
                        .IsUnique()
                        .HasFilter("[ManagerId] IS NOT NULL");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DegreeId"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubId")
                        .HasColumnType("int");

                    b.Property<decimal?>("mark")
                        .HasColumnType("money");

                    b.HasKey("DegreeId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubId");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("SchoolDAL.Modules.StudentAttendance", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("day")
                        .HasColumnType("date");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId", "day");

                    b.ToTable("StudentsAttendance");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("TeacherID");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SchoolDAL.Modules.TeacherAttendance", b =>
                {
                    b.Property<DateTime>("day")
                        .HasColumnType("date");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("day", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeachersAttendance");
                });

            modelBuilder.Entity("SchoolDAL.Modules.TeacherClassSubject", b =>
                {
                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lesson")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("classId")
                        .HasColumnType("int");

                    b.HasKey("date", "Lesson");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.HasIndex("classId");

                    b.ToTable("EnrolllmentTeacherClassSubject");
                });

            modelBuilder.Entity("School.Modules.Student", b =>
                {
                    b.HasOne("SchoolDAL.Modules.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("classId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Class", b =>
                {
                    b.HasOne("SchoolDAL.Modules.Teacher", "Manager")
                        .WithOne("Class")
                        .HasForeignKey("SchoolDAL.Modules.Class", "ManagerId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Degree", b =>
                {
                    b.HasOne("School.Modules.Student", "Student")
                        .WithMany("studentdegrees")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDAL.Modules.Subject", "subject")
                        .WithMany("studentdegrees")
                        .HasForeignKey("SubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("SchoolDAL.Modules.StudentAttendance", b =>
                {
                    b.HasOne("School.Modules.Student", "Student")
                        .WithMany("studentAttend")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Teacher", b =>
                {
                    b.HasOne("SchoolDAL.Modules.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolDAL.Modules.TeacherAttendance", b =>
                {
                    b.HasOne("SchoolDAL.Modules.Teacher", "teacher")
                        .WithMany("teachersattend")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("SchoolDAL.Modules.TeacherClassSubject", b =>
                {
                    b.HasOne("SchoolDAL.Modules.Subject", "Subject")
                        .WithMany("lesson")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDAL.Modules.Teacher", "Teacher")
                        .WithMany("lesson")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDAL.Modules.Class", "classs")
                        .WithMany("lesson")
                        .HasForeignKey("classId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");

                    b.Navigation("classs");
                });

            modelBuilder.Entity("School.Modules.Student", b =>
                {
                    b.Navigation("studentAttend");

                    b.Navigation("studentdegrees");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Class", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("lesson");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Subject", b =>
                {
                    b.Navigation("Teachers");

                    b.Navigation("lesson");

                    b.Navigation("studentdegrees");
                });

            modelBuilder.Entity("SchoolDAL.Modules.Teacher", b =>
                {
                    b.Navigation("Class")
                        .IsRequired();

                    b.Navigation("lesson");

                    b.Navigation("teachersattend");
                });
#pragma warning restore 612, 618
        }
    }
}
