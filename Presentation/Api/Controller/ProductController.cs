using Api.Application.Features.Products.Queries.GetAllProducts;
using Api.Application.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var response = await _mediator.Send(new GetAllProductQueryRequest());
            return Ok(response);
        }
        
    }
}
