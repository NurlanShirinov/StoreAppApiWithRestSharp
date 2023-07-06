namespace StoreApp.Core.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? URL { get; set; }
        public int ProductId { get; set; }
    }
}