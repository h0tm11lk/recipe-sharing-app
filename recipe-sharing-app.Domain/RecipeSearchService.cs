using RecipeSharingApp.Domain;

public class RecipeSearchService
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly ITagRepository _tagRepository;

    public IReadOnlyList<Recipe> SearchRecipes()
    {
        // Fetch all recipes from the repository
        var recipes = _recipeRepository.GetAllRecipes();

        // Optionally, filter or sort recipes based on criteria
        // For example, you could filter by category or tags if needed

        return recipes;
    }
}