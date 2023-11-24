using System.ComponentModel.DataAnnotations.Schema;

namespace Peskit.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Author Author{ get; set; }
        public int AuthorId { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
