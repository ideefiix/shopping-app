using ShoppingAPI.Models.Data;

namespace ShoppingAPI.Models.Api
{
    public class CreateShoppingListRequest
    {
        public required string Name { get; set; }
        public required List<ShopItemCreateWithinListRequest> Items { get; set; }
        public required bool IsCompleted { get; set; }
        public required DateTime DateCompleted { get; set; }
    }

    public class ShopItemCreateWithinListRequest
    {
        public required string Name { get; set; }
    }
}
