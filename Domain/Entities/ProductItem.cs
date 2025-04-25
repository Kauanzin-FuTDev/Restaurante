namespace Domain.Entities
{
    public class ProductItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public required Product Product { get; set; }


        // Dados duplicados para congelar os valores na venda
        public required string  Name { get; set; }
        public decimal Price { get; set; }
    }
}
