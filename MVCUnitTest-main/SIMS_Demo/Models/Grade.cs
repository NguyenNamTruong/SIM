using System;

namespace SIMS_Demo.Models
{
    public class Grade
    {
        public int No { get; set; } // Number or index of the grade entry
        public string Semester { get; set; } // Semester of the grade
        public string SubjectCode { get; set; } // Code of the subject
        public string SubjectName { get; set; } // Name of the subject
        public string GradeValue { get; set; } // Grade obtained by the student
        public decimal Mark { get; set; } // Mark obtained by the student
        public string Status { get; set; } // Status of the grade (e.g., Pass, Fail, In Progress)

        // Constructor
        public Grade()
        {
            // You can add any additional initialization logic here if needed
        }
    }
}
