using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseRegProg.Pages
{
    public class StudentsModel : PageModel
    {
        public List<Student> Students { get; set; }

        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student { StudentId = 1, FirstName = "Barry", LastName = "Allen", Email = "flash@justiceleague.com", PhoneNumber = "123-456-7890" },
                new Student { StudentId = 2, FirstName = "Bruce", LastName = "Wayne", Email = "batman@gotham.com", PhoneNumber = "997-614-9210" },
                new Student { StudentId = 3, FirstName = "Clark", LastName = "Kent", Email = "superman@krypton.com", PhoneNumber = "917-698-6760"}
            };
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        }
    }
}
