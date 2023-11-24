namespace Peskit.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Employee>? Employees { get; set; }
    }
}
