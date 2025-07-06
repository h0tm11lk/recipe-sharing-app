using System.ComponentModel;

namespace RecipeSharingApp.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class User
    {
        public RecipeId Id { get; set; }
        public CreatorId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CookingTime Time { get; set; }
        public string ImageUrl { get; set; }
        public CategoryId Id { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }
        public List<TagId> TagIds { get; set; }

        public User(RecipeId id, CreatorId creatorId, string title, string description, CookingTime time, string imageUrl, CategoryId categoryId)
        {
            Id = id;
            CreatorId = creatorId;
            Title = title;
            Description = description;
            Time = time;
            ImageUrl = imageUrl;
            CategoryId = categoryId;
            IsPublished = false; // Default to not published
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;

            // Initialize collections
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
            TagIds = new List<TagId>();
        }
    }
}