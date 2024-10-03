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
    public  string Title { get; set; }
    public  string Description { get; set; }
    public  int CategoryId { get; set; }
    public  Category Category { get; set; }
    
}