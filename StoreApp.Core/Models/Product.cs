namespace StoreApp.Core.Models
{
    public class Product:BaseModel
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set;}
    }
}