using Microsoft.AspNetCore.Mvc;
using SIMS_Demo.Models;
using System;
using System.Collections.Generic;

namespace SIMS_Demo.Controllers
{
    public class GradeController : Controller
    {
        // Action method to display a list of grades
        public IActionResult Index()
        {
            // Sample data for demonstration
            List<Grade> grades = new List<Grade>
            {
                new Grade { No = 1, Semester = "Spring 2023", SubjectCode = "MATH101", SubjectName = "Mathematics", GradeValue = "A", Mark = 85, Status = "Pass" },
                new Grade { No = 2, Semester = "Spring 2023", SubjectCode = "PHY101", SubjectName = "Physics", GradeValue = "B+", Mark = 78, Status = "Pass" },
                new Grade { No = 3, Semester = "Spring 2023", SubjectCode = "CHEM101", SubjectName = "Chemistry", GradeValue = "A-", Mark = 82, Status = "Pass" }
            };

            return View(grades);
        }
    }
}
