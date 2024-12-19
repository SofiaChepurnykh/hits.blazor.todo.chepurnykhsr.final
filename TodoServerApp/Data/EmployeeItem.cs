using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class EmployeeItem
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Position { get; set; }
        public int Time { get; set; }
        public int Salary { get; set; }
    }
}
