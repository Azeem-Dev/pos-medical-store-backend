using pharmacy_pos.datalayer.Repository;
using pharmacy_pos.datalayer.Repository.ProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
using PT =pharmacy_pos.ef.Entities.ProductType;

namespace pharmacy_pos.servicelayer.Services.ProductType
{
    public class ProductTypeService:IProductTypeService
    {
        private readonly IProductTypeRepo _repo;

        public ProductTypeService(IProductTypeRepo repo)
        {
            _repo = repo;
        }

        public async Task<AddProductTypeRes> AddProductType(AddProductTypeReq req)
        {
            return await _repo.AddProductType(req);
        }

        public async Task<List<GetProductTypes>> GetAllTypes()
        {
            return await _repo.GetAllTypes();
        }
    }
}
