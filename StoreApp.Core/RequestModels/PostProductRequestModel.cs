using StoreApp.Core.Models;

namespace StoreApp.Core.RequestModels
{
    public class PostProductRequestModel
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<string> Images { get; set; }
        public GetCategoryResponseModeltegory Category { get; set; }
    }
}
