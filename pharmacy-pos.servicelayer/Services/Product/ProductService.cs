using pharmacy_pos.datalayer.Repository.Product;
using pharmacy_pos.datalayer.Repository.Product.Dtos;
using pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct;

namespace pharmacy_pos.servicelayer.Services.Product
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductBaseDto>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }
        public async Task<bool> AddProduct(AddProductDto product)
        {
            return await _productRepository.AddProduct(product);
        }
    }
}
