namespace StoreApp.Core.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreationAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}