using Microsoft.EntityFrameworkCore;
using Restful.Core.Models;
using Restful.Core.Repositories;
using Restful.Core.Services;
using Restful.Repository.Repositories;

namespace Restful.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;

        }

        public async Task<Product> AddAsync(Product entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities)
        {
            await _repository.AddRangeAsync(entities);
            return entities;
        }


        public async Task<List<Product>> GetAllAsync()
        {
            return  _repository.GetAll().ToList();
        }

        public Product GetByIdAsync(int id)
        {
            var hasProduct = _repository.GetByIdAsync(id);


            return hasProduct;
        }

        public async Task RemoveAsync(Product entity)
        {
            _repository.Remove(entity);
        }

        public async Task UpdateAsync(Product entity)
        {
            _repository.Update(entity);
        }


    }
}
