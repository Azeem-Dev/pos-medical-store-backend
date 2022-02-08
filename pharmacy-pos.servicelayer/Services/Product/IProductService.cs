using pharmacy_pos.datalayer.Repository.Product.Dtos;
using pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct;

namespace pharmacy_pos.servicelayer.Services.Product
{
    public interface IProductService
    {
        Task<List<ProductBaseDto>> GetAllProducts();
        Task<bool> AddProduct(AddProductDto product);
    }
}
