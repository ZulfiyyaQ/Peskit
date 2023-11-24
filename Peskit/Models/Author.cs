namespace Peskit.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Blog>? Blogs { get; set; }
    }
}
