using System.Collections.Generic;
using api.Models;
using LMS.Models.Courses;

namespace LMS.DTOs.UserDTOs
{
    public class GetUserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public string Role { get; set; }
        public int Points { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<Registration> RegisteredCourses { get; set; }
    }
}