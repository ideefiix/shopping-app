namespace ShoppingAPI.Models.Data
{
    public interface IGuidEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } 
        public DateTime DateUpdated { get; set; }
    }
}
