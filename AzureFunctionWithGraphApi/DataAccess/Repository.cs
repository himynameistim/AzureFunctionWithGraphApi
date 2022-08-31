using AzureFunctionWithGraphApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AzureFunctionWithGraphApi.DataAccess
{
    public interface ISchoolRepository
    {
        List<School> All();
        School GetById(int id);
    }

    public interface IClassRepository
    {
        List<Class> All();
        Class GetById(int id);
        List<Class> GetBySchool(int schoolId);
    }

    public interface IStudentRepository {
        List<Student> All();
        Student GetById(int id);
        List<Student> GetByClass(int classId);
    }

    public static class DemoData
    {
        public static List<School> Schools = new List<School>()
        {
            new School() {Id = 1, Name = "Foo School"},
            new School() {Id = 2 , Name = "Boo School"},
        };

        public static List<Class> ClassList = new List<Class>()
        {
            new Class() {Id = 3, SchoolId = 1, Name = "Red Class", YearGroup = 1},
            new Class() {Id = 4, SchoolId = 1, Name = "Blue Class", YearGroup = 2},
            new Class() {Id =5, SchoolId = 2, Name = "Yellow Class", YearGroup = 1},
            new Class(){Id = 6, SchoolId = 2, Name = "Green Class", YearGroup = 2}
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student() {Id = 1, ClassId = 3, FirstName = "John", Surname = "Smith"},
            new Student() {Id = 2, ClassId = 3, FirstName = "Sam", Surname = "Smith"},
            new Student() {Id = 3, ClassId = 4, FirstName = "Eric", Surname = "Smith"},
            new Student() {Id = 4, ClassId = 4, FirstName = "Rachel", Surname = "Smith"},
            new Student() {Id = 5, ClassId = 5, FirstName = "Tom", Surname = "Smith"},
            new Student() {Id = 6, ClassId = 5, FirstName = "Sally", Surname = "Smith"},
            new Student() {Id = 7, ClassId = 6, FirstName = "Sharon", Surname = "Smith"},
            new Student() {Id = 8, ClassId = 6, FirstName = "Kate", Surname = "Smith"}
        };
    }

    public class SchoolRepository : ISchoolRepository
    {
        public List<School> All()
        {
            return DemoData.Schools;
        }

        public School GetById(int id)
        {
            return DemoData.Schools.Where(x => x.Id == id).FirstOrDefault(); 
        }
    }

    public class ClassRepository : IClassRepository
    {
        public List<Class> All()
        {
            return DemoData.ClassList;
        }

        public Class GetById(int id)
        {
            return DemoData.ClassList.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Class> GetBySchool(int schoolId)
        {
            return DemoData.ClassList.Where((x) => x.SchoolId == schoolId).ToList();
        }
    }

    public class StudentRepository : IStudentRepository
    {
        public List<Student> All()
        {
            return DemoData.Students;
        }

        public List<Student> GetByClass(int classId)
        {
            return DemoData.Students.Where((x) => x.ClassId == classId).ToList();
        }

        public Student GetById(int id)
        {
            return DemoData.Students.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
