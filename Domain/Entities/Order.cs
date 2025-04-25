using Domain.Commun;
using Domain.Utils;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CostumerId { get; set; }
        public required Costumer Costumer { get; set; }
        public decimal TotalPrice { get; set; }
        public Status OrderStatus { get; set; } = Status.Pending;
        
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
    
        
    
}
