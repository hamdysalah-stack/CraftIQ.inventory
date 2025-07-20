using System.ComponentModel.DataAnnotations;

namespace CraftIQ.inventory.EndPoints.Categories
{
    public class CreateCategoryRequest
    {
        //public const string Route = "/categories";

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;


     
    }
}
