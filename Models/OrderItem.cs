namespace MetalUniverse.Models
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public Order? Order { get; set; }
        public int ProductID { get; set; }
        public Product? Product { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
