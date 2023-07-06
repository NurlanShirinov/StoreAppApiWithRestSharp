namespace StoreApp.Core.ResponseModels
{
    public class GetCategoryResponseModel
    {
        public int Id { get; set; }
        public DateTime CreationAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
