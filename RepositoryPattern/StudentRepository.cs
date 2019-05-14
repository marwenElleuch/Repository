using Microsoft.EntityFrameworkCore;
using Repository.Models.Context;
using Repository.Models.Modes;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern
{
    public class StudentRepository : IStudentRepository
    {
        private RepositoryApiContext _context;
        private DbSet<Student> studentEntity;
        public StudentRepository(RepositoryApiContext context)
        {
            _context = context;
            studentEntity = context.Set<Student>();
        }

        public void SaveStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Added;
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentEntity.AsEnumerable();
        }

        public Student GetStudent(long id)
        {
            return studentEntity.SingleOrDefault(s => s.Id == id);
        }

        public void DeleteStudent(long id)
        {
            Student student = GetStudent(id);
            studentEntity.Remove(student);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}