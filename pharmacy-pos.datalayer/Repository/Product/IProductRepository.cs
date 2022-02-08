using pharmacy_pos.datalayer.Repository.Product.Dtos;
using pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct;

namespace pharmacy_pos.datalayer.Repository.Product
{
    public interface IProductRepository
    {
        Task<List<ProductBaseDto>> GetAllProducts();
        Task<bool> AddProduct(AddProductDto product);

    }
}
