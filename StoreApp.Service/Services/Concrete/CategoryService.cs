﻿using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.Repositories.Abstract;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IBaseSqlRepository _sqlRepository;

        public CategoryService(ICategoryRepository categoryRepository, IBaseSqlRepository sqlRepository)
        {
            _categoryRepository = categoryRepository;
            _sqlRepository = sqlRepository;
        }

        public async Task<GetCategoryResponseModel> CreateAsync(UpdateCategoryRequestModel category)
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

        public async Task<GetCategoryResponseModel> GetByIdAsync(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<GetCategoryResponseModel> UpdateAsync(UpdateCategoryRequestModel category, int id)
        {
            var result = await _categoryRepository.UpdateAsync(category, id);
            return result;
        }
    }
}