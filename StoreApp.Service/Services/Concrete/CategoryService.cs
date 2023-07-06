using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Repository.Repositories.Abstract;
using StoreApp.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> CreateAsync(UpdateCategoryRequestModel category)
        {
            var result = await _categoryRepository.CreateAsync(category);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _categoryRepository.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var result = await _categoryRepository.GetAllAsync();
            return result;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<Category> UpdateAsync(UpdateCategoryRequestModel category, int id)
        {
            var result = await _categoryRepository.UpdateAsync(category, id);
            return result;
        }
    }
}