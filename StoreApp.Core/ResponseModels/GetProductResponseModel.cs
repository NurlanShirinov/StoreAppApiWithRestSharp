using StoreApp.Core.Models;

namespace StoreApp.Core.ResponseModels
{
    public class GetProductResponseModel
    {
        public int Id { get; set; }
        public DateTime CreationAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public IEnumerable<string> Images { get; set; }
        public GetCategoryResponseModeltegory Category { get; set; }
    }
}
