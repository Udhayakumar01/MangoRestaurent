using Mango.Services.ProductAPI.Model;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProduct();
        Task<ProductDto> GetProductById(int productId);

        Task<ProductDto> CreateUpdateProduct(ProductDto product);
        Task<bool> DeleteProduct(int productId);
    }
}
