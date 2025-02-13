namespace MetalUniverse.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public User? User { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string? ShippingAddress { get; set; }
        public string? BillingAddress { get; set; }
        public string? Status { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
