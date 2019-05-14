using Repository.Models.Modes;
using System.Collections.Generic;

namespace RepositoryPattern
{
    public interface IStudentRepository
    {
        void SaveStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(long id);
        void DeleteStudent(long id);
        void UpdateStudent(Student student);
    }
}
