using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFramework.Entity
{
    class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("Data Source=DJDD;Initial Catalog=student;User ID=sa;Password=1234567")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
