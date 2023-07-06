﻿using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Repository.CQRS.Commands.Abstract;
using StoreApp.Repository.CQRS.Queries.Abstract;
using StoreApp.Repository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repository.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ICategoryQuery _categoryQuery;
        private readonly ICategoryCommand _categoryCommand;

        public CategoryRepository(ICategoryQuery categoryQuery, ICategoryCommand categoryCommand)
        {
            _categoryQuery = categoryQuery;
            _categoryCommand = categoryCommand;
        }

        public async Task<Category> CreateAsync(UpdateCategoryRequestModel category)
        {
            var result = await _categoryCommand.CreateAsync(category);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _categoryCommand.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var result = await _categoryQuery.GetAllAsync();
            return result;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var result = await _categoryQuery.GetByIdAsync(id);
            return result;
        }

        public async Task<Category> UpdateAsync(UpdateCategoryRequestModel category, int id)
        {
            var result = await _categoryCommand.UpdateAsync(category, id);
            return result;
        }
    }
}