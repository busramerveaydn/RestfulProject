using Restful.Core.Models;

namespace Restful.Core.Services
{
    public interface IService
    {
        Product GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task<Product> AddAsync(Product entity);
        Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities);
        Task UpdateAsync(Product entity);
        Task RemoveAsync(Product entity);


    }
}
