﻿using API.Application.Interfaces.UnitOfWorks;
using API.Domain.Entities;
using MediatR;

namespace API.Application.Features.Products.Queries.GetAllProducts;
public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
{
    private readonly IUnitOfWork unitOfWork;
    public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }
    public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();
        List<GetAllProductsQueryResponse> response = new();
        foreach (var product in products)
        {
            response.Add(new GetAllProductsQueryResponse
            {
                Description = product.Description,
                Discount = product.Discount,
                Price = product.Price - (product.Price*product.Discount /100),
                Title = product.Title,
            });
        }
        return response;
    }
}