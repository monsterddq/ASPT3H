using EFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var db = new StudentDBContext())
            {
                var tran = db.Database.BeginTransaction();
                db.Students.Add(new Student(Utility.GenerateId("std"), "Pham Van A", "phamvana@gmail.com", "HN"));
                db.SaveChanges();
                tran.Commit();
            }
        }
    }
}
