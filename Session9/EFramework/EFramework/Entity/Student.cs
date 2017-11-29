using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EFramework.Utility;
using static System.String;
using static System.Console;

namespace EFramework.Entity
{
    public class Student
    {

        public Student()
        {
        }

        public Student(string studentId)
        {
            StudentId = studentId;
        }

        public Student(string studentId, string name, string email, string address)
        {
            StudentId = studentId;
            Name = name;
            Email = email;
            Address = address;
        }

        [Key]
        [Required]
        public string StudentId { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
    }
}
