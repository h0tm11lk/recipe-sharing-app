using System.ComponentModel;
using System.Xml.Serialization;

namespace RecipeSharingApp.Domain
{
    public class Recipe
    {
        public RecipeId Id { get; set; }
        public UserId CreatorId { get; set; }
        public CategoryId CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CookingTime Time { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }
        public List<TagId> TagIds { get; set; }

        public void UpdateDetails()
        {

        }

        public void AddIngredient()
        {

        }

        public void RemoveIngredient()
        {

        }

        public void UpdateIngredient()
        {

        }

        public void AddStep()
        {

        }

        public void RemoveStep()
        {

        }

        public void UpdateStep()
        {

        }

        public void AddTag()
        {

        }

        public void RemoveTag()
        {

        }

        public void Publish()
        {

        }

        public void Unpublish()
        {

        }
    }
}