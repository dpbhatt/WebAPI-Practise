using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //[RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id= 1, Name = "Tome" },
            new Student() { Id = 2, Name = "Sam" },
            new Student() { Id = 3, Name = "John" }
        };

        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, students);
        //}

        public IHttpActionResult Get()
        {
            return Ok(students);
        }

        //public HttpResponseMessage Get(int id)
        //{
        //    var student = students.FirstOrDefault(s => s.Id == id);

        //    if (student == null)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student not found");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, student);
        //}
        public IHttpActionResult Get(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return Content(HttpStatusCode.NotFound, "Student not found");
            }
            return Ok(student);
        }


        //// Override the RoutePrefix
        //[Route("~/api/teachers")]
        //public IEnumerable<Teacher> GetTeachers()
        //{
        //    List<Teacher> teachers = new List<Teacher>()
        //    {
        //        new Teacher() { Id = 1, Name = "Rob" },
        //        new Teacher() { Id = 1, Name = "Mike" },
        //        new Teacher() { Id = 1, Name = "Mary" }
        //    };

        //    return teachers;
        //}
        //[Route("")]
        //public IEnumerable<Student> Get()
        //{
        //    return students;
        //}

        //// Route Contraint
        //// Only positive value greater than 0 and less than 3
        //[Route("{id:int:min(1):max(3)}")]
        //public Student Get(int id)
        //{
        //    return students.FirstOrDefault(s => s.Id == id);
        //}

        ////[Route("{id:int}", Name = "GetStudentById")]
        ////public Student Get(int id)
        ////{
        ////    return students.FirstOrDefault(s => s.Id == id);
        ////}

        ////public HttpResponseMessage Post(Student student)
        ////{
        ////    students.Add(student);
        ////    var response = Request.CreateResponse(HttpStatusCode.Created);
        ////    response.Headers.Location = new Uri(Url.Link("GetStudentById", new { id= student.Id}));
        ////    return response;
        ////}

        //[Route("{name:alpha}")]
        //public Student Get(string name)
        //{
        //    return students.FirstOrDefault(s => s.Name.ToLower() == name.ToLower());
        //}

        //[Route("{id}/courses")]
        //public IEnumerable<string> GetStudentCourses(int id)
        //{
        //    if (id == 1)
        //        return new List<String>() { "C#", "ASP.NET", "SQL Server" };
        //    else if (id == 2)
        //        return new List<string>() { "ASP.NET Web API", "C#", "SQL Server" };
        //    else
        //        return new List<string> { "Bootstrap", "JQuery", "AngularJs" };
        //}
    }
}