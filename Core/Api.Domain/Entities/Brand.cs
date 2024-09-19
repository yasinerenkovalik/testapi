using Api.Domain.Commen.Commen;

namespace Api.Domain.Commen.Entities;

public class Brand:EntityBase
{
    public Brand()
    {
        
    }
    public Brand(string name)
    {
        Name = name;
    }
    public required string Name { get; set; }
    
}