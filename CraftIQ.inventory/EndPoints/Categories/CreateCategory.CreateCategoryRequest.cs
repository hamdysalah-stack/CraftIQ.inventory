namespace CraftIQ.inventory.EndPoints.Categories
{
    public class CreateCategoryRequest
    {
        //public const string Route = "/categories";
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
