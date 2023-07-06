using StoreApp.Core.Models;

namespace StoreApp.Core.RequestModels
{
    public class UpdateProductRequestModel
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public GetCategoryResponseModeltegory Category { get; set; }
    }
}
