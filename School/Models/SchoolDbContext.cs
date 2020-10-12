using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
      
        public DbSet<Teacher> Teachers { set; get; }
        public virtual DbSet<Student> Students { set; get; }
        public DbSet<term> Terms { set; get; }
        public DbSet<Subject> Subjects { set; get; }
        public DbSet<TeacherTerm> termteacher { set; get; }
        public DbSet<HR> Hr { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var reationship in modelBuilder.Model.GetEntityTypes().SelectMany(e=>e.GetForeignKeys()))
            {
                reationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}

