using Api.Application.UnitOfWorks;
using Api.Application2.Interfaces.AutoMapper;
using Api.Domain.Commen.Entities;
using MediatR;

namespace Api.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductQueryHandler:IRequestHandler<GetAllProductQueryRequest,IList<GetAllProductQueryResponse>>
{
    private readonly IUnitOfWorks _unitOfWorks;
    private readonly IMapper _mapper;
    public GetAllProductQueryHandler(IUnitOfWorks unitOfWorks,IMapper mapper)
    {
        _unitOfWorks = unitOfWorks;
        _mapper = mapper;
    }
    public async Task<IList<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await _unitOfWorks.GetReadRepository<Product>().GetAllAsync();
     
        var map = _mapper.Map<GetAllProductQueryResponse,Product>(products);


        
            


    }
}