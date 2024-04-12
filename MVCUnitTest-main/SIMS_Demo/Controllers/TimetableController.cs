using Microsoft.AspNetCore.Mvc;
using SIMS_Demo.Models;
using System.Collections.Generic;

namespace SIMS_Demo.Controllers
{
    public class TimetableController : Controller
    {
        // Action để hiển thị danh sách lịch trình
        public IActionResult Index()
        {
            // Điều này có thể là nơi bạn lấy danh sách lịch trình từ cơ sở dữ liệu
            List<Timetable> timetables = new List<Timetable>
            {
                new Timetable { Id = 1, Title = "Meeting", StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1), Location = "Room 101", Description = "Team meeting", Organizer = "John Doe", Status = "In Progress" },
                new Timetable { Id = 2, Title = "Training", StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(2), Location = "Training Room", Description = "Training session", Organizer = "Jane Smith", Status = "Planned" }
            };

            return View(timetables);
        }

        // Action để hiển thị form thêm mới lịch trình
        public IActionResult NewTimetable()
        {
            // Hiển thị form thêm mới lịch trình
            return View();
        }

        // Action để xử lý việc thêm mới lịch trình
        [HttpPost]
        public IActionResult NewTimetable(Timetable timetable)
        {
            // Xử lý logic để thêm mới lịch trình vào cơ sở dữ liệu
            // Sau đó chuyển hướng người dùng đến trang danh sách lịch trình
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            // Here, you would typically fetch the timetable entry details from your data source
            // For demonstration purposes, let's create a sample timetable entry
            Timetable timetable = new Timetable
            {
                Id = id,
                Title = "Sample Timetable Entry",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(1),
                Location = "D408",
                Description = "Sample Description",
                Organizer = "Dinh Van Dong",
                Status = "Sample Status"
            };

            // Pass the timetable entry to the view
            return View(timetable);
        }

    }
}
