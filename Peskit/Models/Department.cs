using System.ComponentModel.DataAnnotations.Schema;

namespace Peskit.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        List<Employee>? Employees { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }

    }
}
