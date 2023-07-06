namespace StoreApp.Core.Models
{
    public class Product:BaseModel
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set;}
        public int CategoryId { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public GetCategoryResponseModeltegory Category { get; set; }
    }
}