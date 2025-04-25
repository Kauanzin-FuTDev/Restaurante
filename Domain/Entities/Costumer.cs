using Domain.Commun;

namespace Domain.Entities
{
    public class Costumer : BaseEntity
    {
        string Name { get; set; } = string.Empty;
        string Email { get; set; } = string.Empty;
        string Phone { get; set; } = string.Empty;
        string PassWord { get; set; } = string.Empty;

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}

