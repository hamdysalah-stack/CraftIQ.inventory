namespace CraftIQ.inventory.EndPoints.Categories
{
    public class CreateCategoryResponse
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public CreateCategoryResponse(string name , string description)
        {
            Name = name;
            Description = description;

        }
    }
}
