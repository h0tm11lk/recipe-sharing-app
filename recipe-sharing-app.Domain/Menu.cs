public class Menu
    {
        public MenuId Id { get; set; }
        public UserId CreatorId { get; set; }
        public DateOnly MenuDate { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }