using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            using (var context = new StudentDBContext())
            {
                //get all students
                //return context.Students.ToList();

                //add a student in database
                //Student s = new Student();
                //s.FirstName = "Khushboo";
                //s.LastName = "Awatramani";
                //s.StudentId = 15;
                //context.Students.Add(s);
                //context.SaveChanges();

                //get students by id
                //return context.Students.Where(s => s.StudentId == 1).ToList();

                //added student in db
                //return context.Students.Where(s => s.FirstName == "Khushboo").ToList();

                //to update
                //Student stu = context.Students.Where(s => s.FirstName == "Khushboo").FirstOrDefault();
                //stu.StudentId = 5;
                //stu.RollNo = 15;
                //context.SaveChanges();

                //remove
                //Student stu = context.Students.Where(s => s.FirstName=="Khushboo").FirstOrDefault();
                //context.Students.Remove(stu);
                //context.SaveChanges();
                return context.Students.ToList();
            }
        }
        
    }
}
