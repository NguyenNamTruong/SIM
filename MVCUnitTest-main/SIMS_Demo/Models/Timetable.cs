using System;

namespace SIMS_Demo.Models
{
    public class Timetable
    {
        public int Id { get; set; } // Định danh duy nhất của lịch trình
        public string Title { get; set; } // Tiêu đề hoặc tên của lịch trình
        public DateTime StartTime { get; set; } // Thời gian bắt đầu của lịch trình
        public DateTime EndTime { get; set; } // Thời gian kết thúc của lịch trình
        public string Location { get; set; } // Địa điểm hoặc phòng học của lịch trình
        public string Description { get; set; } // Mô tả hoặc thông tin chi tiết về lịch trình
        public string Organizer { get; set; } // Người tổ chức lịch trình (nếu có)
        public string Status { get; set; } // Trạng thái của lịch trình (hoàn thành, chưa hoàn thành, đang diễn ra, v.v.)

        // Hàm khởi tạo mặc định của lớp
        public Timetable()
        {
        }
    }
}