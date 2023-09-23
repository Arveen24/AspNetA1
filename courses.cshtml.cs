using System.Collections.Generic;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseRegProg.Pages
{
    public class CoursesModel : PageModel
    {
        public List<Course> Courses { get; set; }

        public void OnGet()
        {
            Courses = new List<Course>
            {
                new Course { CourseId = 1, CourseNumber = "CSCI101", CourseName = "Introduction to Computer Science", Description = "Fundamentals of programming and computer science" },
                new Course { CourseId = 2, CourseNumber = "MATH201", CourseName = "Calculus I", Description = "Basic calculus concepts" },
                new Course { CourseId = 3, CourseNumber = "BIOS102", CourseName = "Biological Science", Description = "Advance Biology"}
            };
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string CourseNumber { get; set; }
            public string CourseName { get; set; }
            public string Description { get; set; }
        }
    }
}
