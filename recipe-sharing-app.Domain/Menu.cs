using System.Diagnostics.Contracts;

public class Menu
{
    public MenuId Id { get; set; }
    public UserId CreatorId { get; set; }
    public DateOnly MenuDate { get; set; }
    public List<MenuItem> MenuItems { get; set; }

    public void AddMenuItem()
    {
        // Logic to add a menu item
    }

    public void RemoveMenuItem()
    {
        // Logic to remove a menu item
    }

    public void UpdateMenuItemServingCount()
    {
        // Logic to update the serving count of a menu item
    }
}