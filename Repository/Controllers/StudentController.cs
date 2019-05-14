using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models.Modes;
using Repository.ViewModels;
using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StudentController : Controller
    {
        private IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<StudentViewModel> model = studentRepository.GetAllStudents().Select(s => new StudentViewModel
            {
                Id = s.Id,
                Name = $"{s.FirstName} {s.LastName}",
                EnrollmentNo = s.EnrollmentNo,
                Email = s.Email
            });

            return Ok(model);
            //return View("Index", model);
        }

        [HttpGet("Get/{id}")]
        public IActionResult GetById(int id)
        {
            Student student = studentRepository.GetStudent(id);
            return Ok(student);
        }

        [HttpGet("{id}")]
        public IActionResult AddEditStudent(long? id)
        {
            StudentViewModel model = new StudentViewModel();
            if (id.HasValue)
            {
                Student student = studentRepository.GetStudent(id.Value); if (student != null)
                {
                    model.Id = student.Id;
                    model.FirstName = student.FirstName;
                    model.LastName = student.LastName;
                    model.EnrollmentNo = student.EnrollmentNo;
                    model.Email = student.Email;
                }
            }
            return PartialView("~/Views/Student/_AddEditStudent.cshtml", model);
        }

        [HttpPost("add")]
        public ActionResult AddEditStudent(long? id,[FromBody] StudentViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    Student student = isNew ? new Student
                    {
                        AddedDate = DateTime.UtcNow
                    } : studentRepository.GetStudent(id.Value);
                    student.FirstName = model.FirstName;
                    student.LastName = model.LastName;
                    student.EnrollmentNo = model.EnrollmentNo;
                    student.Email = model.Email;
                    student.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                    student.ModifiedDate = DateTime.UtcNow;
                    if (isNew)
                    {
                        studentRepository.SaveStudent(student);
                    }
                    else
                    {
                        studentRepository.UpdateStudent(student);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet("Delete/{id}")]
        public IActionResult DeleteStudent(long id)
        {
            Student student = studentRepository.GetStudent(id);
            StudentViewModel model = new StudentViewModel
            {
                Name = $"{student.FirstName} {student.LastName}"
            };
            return PartialView("~/Views/Student/_DeleteStudent.cshtml", model);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudentAction(long id)
        {
            studentRepository.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
