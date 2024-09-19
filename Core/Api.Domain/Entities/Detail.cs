using Api.Domain.Commen.Commen;

namespace Api.Domain.Commen.Entities;

public class Detail:EntityBase
{
    public Detail()
    {
        
    }
    public Detail(string title,string description,int categoryId)
    {
        Title = title;
        Description = description;
        categoryId = categoryId;
    }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int CategoryId { get; set; }
    public required Category Category { get; set; }
    
}