using AzureFunctionWithGraphApi.DataAccess;
using AzureFunctionWithGraphApi.Models;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionWithGraphApi
{
    public class Query
    {
        public List<School> GetSchools([Service] ISchoolRepository schoolRepository)
        {
            return schoolRepository.All();
        }
        public School GetSchoolById([Service] ISchoolRepository schoolRepository, int schoolId)
        {
            return schoolRepository.GetById(schoolId);
        }

        public List<Class> GetClasses([Service] IClassRepository classRepository)
        {
            return classRepository.All();
        }
        public Class GetClassById([Service] IClassRepository classRepository, int classId)
        {
            return classRepository.GetById(classId);
        }

        public List<Class> GetClassesBySchoolId([Service] IClassRepository classRepository, int schoolId)
        {
            return classRepository.GetBySchool(schoolId);
        }

        public List<Student> GetStudents([Service] IStudentRepository studentRepository)
        {
            return studentRepository.All();
        }
        public Student GetStudentById([Service] IStudentRepository studentRepository, int studentId)
        {
            return studentRepository.GetById(studentId);
        }

        public List<Student> GetStudentsBySchoolId([Service] IStudentRepository studentRepository, int classId)
        {
            return studentRepository.GetByClass(classId);
        }
    }
}
