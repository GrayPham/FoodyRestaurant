using Food.Web.Models;
using Food.Web.Services.IServices;

namespace Food.Web.Services
{
    public class ProductService : BaseService, IProductServices
    {
        public Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteProductAsync<T>(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAllProductsAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetProductByIdAsync<T>(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
