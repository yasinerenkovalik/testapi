using Api.Application2.DTOs;

namespace Api.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductQueryResponse
{
    public  string Title { get; set; }
    
    public  string Description { get; set; }
    
    public  decimal Price { get; set; }
    
    public  decimal Discount { get; set; }
    
    public BrandDto Brand { get; set; }
}