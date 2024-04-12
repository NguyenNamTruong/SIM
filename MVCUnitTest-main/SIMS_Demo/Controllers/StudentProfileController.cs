using Microsoft.AspNetCore.Mvc;
using SIMS_Demo.Models;

namespace SIMS_Demo.Controllers
{
    public class StudentProfileController : Controller
    {
        // Action method to display student profile
        public IActionResult Index()
        {
            // Retrieve student profile data from the database or any other source
            // For demonstration purposes, let's create a sample student profile
            var studentProfile = new StudentProfile
            {
                StudentId = "S001",
                Name = "John Doe",
                DateOfBirth = new System.DateTime(2000, 1, 1),
                Email = "john.doe@example.com",
                Department = "Computer Science",
                Address = "123 Main St, City",
                Phone = "123-456-7890",
                GuardianPhone = "987-654-3210",
                AdmissionDate = new System.DateTime(2018, 9, 1),
                AdmissionStatus = "Active",
                ProfilePicturePath = "C:\\Users\\admin\\Downloads\\T7-main\\1233\\MVCUnitTest-main\\SIMS_Demo\\wwwroot\\image\\Screenshot 2024-03-08 222159.png" // Example path to the profile picture
            };

            return View(studentProfile);
        }
    }
}
