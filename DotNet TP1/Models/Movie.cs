using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet_TP1.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
