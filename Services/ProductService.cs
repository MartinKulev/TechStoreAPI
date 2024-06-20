using System.Text.Json;
using TechStoreAPI.Data.Entities;
using TechStoreAPI.Repositories;

namespace TechStoreAPI.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<JsonDocument> GetProductJsonByIDAsync(int productID)
        {
            Product product = await productRepository.GetProductByIDAsync(productID);
            string jsonString = JsonSerializer.Serialize(product);
            JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
            return jsonDocument;
        }

        public async Task<JsonDocument> GetAllProductsJsonAsync()
        {
            List<Product> products = await productRepository.GetAllProducts();
            string jsonString = JsonSerializer.Serialize(products);
            JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
            return jsonDocument;
        }
    }
}
