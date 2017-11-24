using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuotProject
{
    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
    public class Student
    {
        public Student() { }
        public Student(int id, string name, string phone)
        {
            this.StudentId = id;
            this.StudentName = name;
            this.StudentPhone = phone;
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public override string ToString()
        {
            return "Id:" + this.StudentId + ", Name:" + this.StudentName + ", Phone:" + this.StudentPhone;
        }
    }
    public class Log
    {
        public Log() { }
        public Log(int id, string name)
        {
            this.LogId = id;
            this.LogName = name;
        }
        public int LogId { get; set; }
        public string LogName { get; set; }
        public override string ToString()
        {
            return "Id:" + this.LogId + ", Name:" + this.LogName;
        }
    }

    public class Utility
    {


        public static List<Student> lstStudent = new List<Student>()
        {
            new Student()  { StudentId=1, StudentName= "Phạm Ngọc Anh", StudentPhone = "0916276494"},
            new Student()  { StudentId=2, StudentName= "Phạm Anh", StudentPhone = "0916276495"},
            new Student()  { StudentId=3, StudentName= "Anh Phạm", StudentPhone = "0916276496"}
        };

        public static List<Log> lstLog = new List<Log>()
        {
            new Log()  { LogId=1, LogName="Phạm Ngọc Anh"},
            new Log()  { LogId=2, LogName="Phạm Anh"},
            new Log()  { LogId=3, LogName="Ngọc Anh"}

        };
    }
    public interface ICommonObject<T, K>
    {
        List<T> GetAll();
        void AddNew(T obj);
        void Modify(T obj);
        void Delete(K obj);
    }
    public abstract class AbstractCommon<T, K> : ICommonObject<T, K>
    {
        public void AddNew(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(K obj)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Modify(T obj)
        {
            throw new NotImplementedException();
        }
    }
    public class StudentServices : AbstractCommon<Student, int>
    {
        public void AddStudent()
        {
            Student objStudent = new Student();
            AddNew(objStudent);
        }
        public void ModifyStudent()
        {
            Student objStudent = new Student();
            Modify(objStudent);
        }
        public void DeleteStudent()
        {
            Student objStudent = new Student();
            Delete(objStudent.StudentId);
        }
        public List<Student> GetAllStudent()
        {
            return GetAll();
        }
    }
    public class LogServices : AbstractCommon<Log, int>
    {
        public void AddLog()
        {
            Log objLog = new Log();
            AddNew(objLog);
        }
        public void ModifyLog()
        {
            Log objLog = new Log();
            Modify(objLog);
        }
        public void DeleteLog()
        {
            Log objLog = new Log();
            Delete(objLog.LogId);
        }
        public List<Log> GetAllLog()
        {
            return GetAll();
        }
    }
}
