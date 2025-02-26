namespace NetShop.Infrastucture.Models;

public class BaseModel
{
    public Guid Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
    public bool IsDeleted { get; set; }
}