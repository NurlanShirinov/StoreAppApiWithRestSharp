﻿using Microsoft.EntityFrameworkCore;
using RestSharp;
using StoreApp.Core.DAL;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.CQRS.Commands.Abstract;
using System.Data;
using System.Data.SqlClient;

namespace StoreApp.Repository.CQRS.Commands.Concrete
{
    public class CategoryCommand : ICategoryCommand
    {
        private readonly RestClient _client;
        private readonly AppDbContext _context;

        public CategoryCommand(AppDbContext context)
        {
            _client = new RestClient("https://api.escuelajs.co");
            _context = context;
        }

        public async Task<GetCategoryResponseModel> CreateAsync(UpdateCategoryRequestModel category)
        {
            try
            {
                var request = new RestRequest("/api/v1/categories/").AddJsonBody(category);
                var response = await _client.ExecutePostAsync<GetCategoryResponseModel>(request);
                //_context.Categories.FromSqlRaw($"AddCategory {category}");
                _context.Database.ExecuteSqlRaw("EXEC AddCategory @category", category.Name);
                return response.Data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var request = new RestRequest("/api/v1/categories/{id}", Method.Delete);
                request.AddUrlSegment("id", id.ToString());
                var response = await _client.ExecuteAsync(request);
                if (!response.IsSuccessful) { return false; }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetCategoryResponseModel> UpdateAsync(UpdateCategoryRequestModel category, int id)
        {
            try
            {
                var requst = new RestRequest("api/v1/categories/{id}")
                    .AddUrlSegment("id", id)
                    .AddJsonBody(category);
                var response = await _client.ExecutePutAsync<GetCategoryResponseModel>(requst);
                return response.Data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
