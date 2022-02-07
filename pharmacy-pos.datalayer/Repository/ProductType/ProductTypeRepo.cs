using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
using ProductTypeEntity = pharmacy_pos.ef.Entities.ProductType.ProductType;

namespace pharmacy_pos.datalayer.Repository.ProductType
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private readonly IRepository<ProductTypeEntity> _productTypeRepo;

        public ProductTypeRepo(IRepository<ProductTypeEntity> productTypeRepo)
        {
            _productTypeRepo = productTypeRepo;
        }
        public async Task<AddProductTypeRes> AddProductType(AddProductTypeReq request)
        {
            var entity = new ProductTypeEntity()
            {
                TypeName = request.TypeName
            };

            await _productTypeRepo.Add(entity);
            if (!string.IsNullOrEmpty(entity.Id.ToString()))
            {
                await _productTypeRepo.Save();
            }
            return new AddProductTypeRes
            {
                Id = entity.Id.ToString(),
                TypeName = entity.TypeName,
            };

        }
        public async Task<List<GetProductTypes>> GetAllTypes()
        {
            var result = await _productTypeRepo.GetAll();
            return result.Select(c => new GetProductTypes
            {
                Id = c.Id.ToString(),
                TypeName = c.TypeName
            }).ToList();
        }
    }
}
