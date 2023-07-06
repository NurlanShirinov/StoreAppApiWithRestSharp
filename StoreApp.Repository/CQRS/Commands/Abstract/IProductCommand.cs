using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.CQRS.Commands.Abstract
{
    public interface IProductCommand
    {
        Task<GetProductResponseModel> CreateAsync(PostProductRequestModel product);
        Task<GetProductResponseModel> UpdateAsync(UpdateProductRequestModel product, int id);
        Task<bool> DeleteAsync(int id);
    }
}
