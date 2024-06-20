using TechStoreAPI.Data.Entities;

namespace TechStoreAPI.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIDAsync(int productID);

        Task<List<Product>> GetAllProducts();
    }
}
