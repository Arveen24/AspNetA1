using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseRegProg.Pages
{
    public class InstructorsModel : PageModel
    {
        public List<Instructor> Instructors { get; set; }

        public void OnGet()
        {
            Instructors = new List<Instructor>
            {
                new Instructor { InstructorId = 1, FirstName = "Kobe", LastName = "Bryant", Email = "mamba24@lakers.com", CourseTeaching = "Math 101" },
                new Instructor { InstructorId = 2, FirstName = "Michael", LastName = "Jordan", Email = "airness23@bulls.com", CourseTeaching = "History 101" },
                new Instructor { InstructorId = 3, FirstName = "LeBron", LastName = "James", Email = "chosenone@cavaliers.com", CourseTeaching = "French 101" }
            };
        }

        public class Instructor
        {
            public int InstructorId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string CourseTeaching { get; set; }
        }
    }
}
