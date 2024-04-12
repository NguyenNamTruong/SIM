using System;

namespace SIMS_Demo.Models
{
    public class StudentProfile
    {
        public string StudentId { get; set; } // Student ID or unique identifier
        public string Name { get; set; } // Student's name
        public DateTime DateOfBirth { get; set; } // Student's date of birth
        public string Email { get; set; } // Student's email address
        public string Department { get; set; } // Student's department
        public string Address { get; set; } // Student's home address
        public string Phone { get; set; } // Student's phone number
        public string GuardianPhone { get; set; } // Guardian's phone number
        public DateTime AdmissionDate { get; set; } // Student's admission date
        public string AdmissionStatus { get; set; } // Admission status (e.g., Active, Inactive)
        public string ProfilePicturePath { get; set; } // Path to the student's profile picture
        // Add more properties as needed
        public StudentProfile() { }
    }
    
}
