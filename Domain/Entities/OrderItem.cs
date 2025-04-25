namespace Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        public List<ProductItem> Product { get; set; } = new List<ProductItem>();

    }
}

