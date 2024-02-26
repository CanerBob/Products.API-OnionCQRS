using MediatR;

namespace API.Application.Features.Products.Queries.GetAllProducts;
public class GetAllProductsQueryRequest:IRequest<IList<GetAllProductsQueryResponse>>
{

}