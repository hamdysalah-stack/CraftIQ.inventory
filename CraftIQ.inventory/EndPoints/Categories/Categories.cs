using CraftIQ.inventory.Core.Entities;
using huzcodes.Endpoints.Abstractions;
using huzcodes.Extensions.Exceptions;
using huzcodes.Persistence.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.inventory.EndPoints.Categories
{
    public class Categories(IRepository<Category> repository) : EndpointsAsync
                                                                         .WithRequest<CreateCategoryRequest>
                                                                         .WithActionResult<CreateCategoryResponse>
    {

        private readonly IRepository<Category> _repository = repository;

        [HttpPost(Routes.CtegoriesRoutes.CreateCategory)]
        public override async Task<ActionResult<CreateCategoryResponse>> HandleAsync
                        (CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            // Implementation
            if (request == null)
                throw new ResultException("Request cannot be null", StatusCodes.Status400BadRequest);

            var OData = new Category(request.Name, request.Description);

            var Oresult = await _repository.AddAsync(OData);

            return Ok(new CreateCategoryResponse(Oresult.Name, Oresult.Description));
           



        }
    }
}
