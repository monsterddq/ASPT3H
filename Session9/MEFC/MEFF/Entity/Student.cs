using System;
using System.ComponentModel.DataAnnotations;

namespace MEFF
{
  public class Student
  {
    public Student(){}
    public Student(string StudentId){
      StudentId = StudentId;
    }

    [Key]
    [Required]
    public string StudentId {get;set;}
    [Required]
    public string Name {get;set;}
    [EmailAddress]
    public string Email {get;set;}
    [Phone]
    public string Phone {get;set;}
  }

}
