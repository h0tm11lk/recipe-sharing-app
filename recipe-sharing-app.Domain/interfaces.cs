using RecipeSharingApp.Domain;

public interface IRecipeRepository
{
    Recipe? FindById();
    void Save();
    void Delete();
    IReadOnlyList<Recipe> FindByCriteria();
}

public interface IUserRepository
{
    User? FindById();
    User? FindByEmail();
    void Save();
    void Delete();
}

public interface IMenuRepository
{
    Menu? FindById();
    IReadOnlyList<Menu> FindByCreatorId();
    void Save();
    void Delete();
}

public interface ICategoryRepository
{
    IReadOnlyList<Category> FindAll();
    Category? FindById();
    void Save();
}

public interface ITagRepository
{
    IReadOnlyList<Tag> FindAll();
    Tag? FindById();
    void Save();
}