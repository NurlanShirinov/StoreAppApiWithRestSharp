using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.CQRS.Queries.Abstract
{
    public interface IProductQuery
    {
        Task<IEnumerable<GetProductResponseModel>> GetAllAsync();
        Task<GetProductResponseModel> GetByIdAsync(int id);
        Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId);
    }
}
