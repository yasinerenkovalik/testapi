using Api.Domain.Commen.Entities;
using MediatR;

namespace Api.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductQueryRequest:IRequest<IList<GetAllProductQueryResponse>>
{
    
}