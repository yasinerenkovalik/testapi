namespace Api.Domain.Commen.Commen;

public class EntityBase:IEntityBase
{
    public int Id { get; set; }
    public DateTime CreateDateTime { get; set; }
    public bool IsDeleted { get; set; }
    
}