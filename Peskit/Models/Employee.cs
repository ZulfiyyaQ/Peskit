using System.ComponentModel.DataAnnotations.Schema;

namespace Peskit.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string InstaLink { get; set; }
        public string FaceLink { get; set; }
        public string TvitLink { get; set; }
        public string LinkLink { get; set; }
        public Position Position { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
