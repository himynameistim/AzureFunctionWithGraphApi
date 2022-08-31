using AzureFunctionWithGraphApi.DataAccess;
using AzureFunctionWithGraphApi.Models;
using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;

namespace AzureFunctionWithGraphApi
{
    [ExtendObjectType(typeof(School))]
    public class SchoolExtensions
    {
        public List<Class> GetClasses([Parent] School school, [Service] IClassRepository classRepository)
        {
            return classRepository.GetBySchool(school.Id);
        }
    }

    [ExtendObjectType(typeof(Class))]
    public class ClassExtensions
    {
        public School GetSchool([Parent] Class schoolClass, [Service] ISchoolRepository schoolRepository)
        {
            return schoolRepository.GetById(schoolClass.SchoolId);
        }
        public List<Student> GetStudents([Parent] Class schoolClass, [Service] IStudentRepository studentRepository)
        {
            return studentRepository.GetByClass(schoolClass.Id);
        }
    }

    [ExtendObjectType(typeof(Student))]
    public class StudentExtensions
    {
        public Class GetClass([Parent] Student student, [Service] IClassRepository classRepository)
        {
            return classRepository.GetById(student.ClassId);
        }
    }
}
