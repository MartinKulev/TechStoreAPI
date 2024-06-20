using Microsoft.EntityFrameworkCore;
using TechStoreAPI.Data;
using TechStoreAPI.Data.Entities;

namespace TechStoreAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private TechStoreDbContext context;

        public ProductRepository(TechStoreDbContext context)
        {
            this.context = context;
        }

        public async Task<Product> GetProductByIDAsync(int productID)
        {
            return await context.Products.FirstAsync(p => p.ProductID == productID);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await context.Products.ToListAsync();
        }
    }
}
