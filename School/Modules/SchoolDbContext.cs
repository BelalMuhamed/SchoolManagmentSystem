using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using SchoolDAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Modules
{
    public class SchoolDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BE6MD1V;Database=SchoolDb;Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentAttendance> StudentsAttendance { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherAttendance> TeachersAttendance { get; set; }
        public DbSet<TeacherClassSubject> EnrolllmentTeacherClassSubject { get; set; }
        public DbSet<user> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<user>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

    }
}
