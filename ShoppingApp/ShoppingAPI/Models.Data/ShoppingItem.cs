using System.ComponentModel;

namespace ShoppingAPI.Models.Data
{
    public class ShoppingItem : IGuidEntity
    {
        public Guid Id { get; set; }
        public required DateTime DateCreated { get; set; }
        public required DateTime DateUpdated { get; set; }
        public required ShoppingList BelongToList { get; set; }
        public required string Name { get; set; }
        public required bool IsCompleted { get; set; }
        public required DateTime DateCompleted { get; set; }
    }
}
