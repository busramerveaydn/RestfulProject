using Restful.Core.Models;

namespace Restful.Core.Repositories
{
    public interface IRepository
    {

        Product GetByIdAsync(int id);
        List<Product> GetAll();
        Task AddAsync(Product entity);
        Task AddRangeAsync(IEnumerable<Product> entities);
        void Update(Product entity);
        void Remove(Product entity);
    }
}
