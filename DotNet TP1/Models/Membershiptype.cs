namespace DotNet_TP1.Models
{
    public class Membershiptype
    {
        public int Id { get; set; }
        public float SignUpFee { get; set; }
        public int DurationInMonth { get; set; }
        public float DiscountRate { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
