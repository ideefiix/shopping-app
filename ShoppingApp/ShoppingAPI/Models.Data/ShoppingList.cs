namespace ShoppingAPI.Models.Data
{
    public class ShoppingList : IGuidEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public required List<ShoppingItem> Items { get; set; }
        public required string Name { get; set; }
        public required bool IsCompleted { get; set; }
        public required DateTime DateCompleted { get; set; }
    }
}
