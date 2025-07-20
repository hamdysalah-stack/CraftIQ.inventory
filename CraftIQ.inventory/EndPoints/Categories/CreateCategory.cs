using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.inventory.EndPoints.Categories
{
    public class CreateCategory : EndpointsAsync.WithRequest<CreateCategoryRequest>
                                                                     .WithActionResult<CreateCategoryResponse>
    {
        [HttpPost(Routes.CtegoriesRoutes.CreateCategory)]
        public override async Task<ActionResult<CreateCategoryResponse>> HandleAsync
                        (CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            // Implementation
            var OResult = new CreateCategoryResponse(request.Name, request.Description);

            return Ok(OResult);
        }
    }
}
