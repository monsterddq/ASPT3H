using System;
using Microsoft.EntityFrameworkCore;

namespace MEFF
{
  public class StudentDBContext : DbContext
  {
    public StudentDBContext():base(){

    }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }


        public virtual DbSet<Student> Students {get;set;}
  }
}
