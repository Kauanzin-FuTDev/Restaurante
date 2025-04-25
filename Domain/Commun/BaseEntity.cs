namespace Domain.Commun
{
    public class BaseEntity
    {
        int Id { get; set; }
        DateTime CreateAt { get; set; }
        DateTime UpdateAt { get; set; }
        bool IsDeleted { get; set; }

    }
}
