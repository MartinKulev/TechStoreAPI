using System.Text.Json;

namespace TechStoreAPI.Services
{
    public interface IProductService
    {
        Task<JsonDocument> GetProductJsonByIDAsync(int productID);

        Task<JsonDocument> GetAllProductsJsonAsync();
    }
}
