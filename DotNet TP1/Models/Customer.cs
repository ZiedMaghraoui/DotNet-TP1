namespace DotNet_TP1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MembershiptypeId { get; set; }
        public Membershiptype? Membershiptype { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}
