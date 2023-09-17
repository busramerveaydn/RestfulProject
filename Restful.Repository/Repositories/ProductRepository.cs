using Restful.Core.Models;
using Restful.Core.Repositories;

namespace Restful.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> EntityList { get; set; }

        public ProductRepository()
        {
            EntityList = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = (decimal)150.35,
                    Stock = 5,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = (decimal)30.35,
                    Stock = 10,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                }
            };
        }

        public async Task AddAsync(Product entity)
        {
            EntityList.Add(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Product> entities)
        {
            EntityList.AddRange(entities);
        }

        public List<Product> GetAll()
        {
            return EntityList;
        }

        public Product GetByIdAsync(int id)
        {
            return EntityList.FirstOrDefault(r => r.Id == id);
        }

        public void Remove(Product entity)
        {

            EntityList.Remove(entity);
        }


        public void Update(Product entity)
        {
            var oldEntity = EntityList.FirstOrDefault(r => r.Id == entity.Id);
            EntityList.Remove(oldEntity);
            EntityList.Add(entity);
        }

    }
}
