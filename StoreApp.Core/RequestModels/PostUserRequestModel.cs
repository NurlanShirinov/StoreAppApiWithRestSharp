namespace StoreApp.Core.RequestModels
{
    public class PostUserRequestModel
    {
        public DateTime CereationAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Avatar { get; set; }
    }
}
