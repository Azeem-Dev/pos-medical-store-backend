using AutoMapper;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
using ProductTypeEntity = pharmacy_pos.ef.Entities.ProductType.ProductType;

namespace pharmacy_pos.datalayer.Repository.ProductType
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private readonly IRepository<ProductTypeEntity> _productTypeRepo;
        private readonly IMapper _mapper;

        public ProductTypeRepo(IRepository<ProductTypeEntity> productTypeRepo, IMapper mapper)
        {
            _productTypeRepo = productTypeRepo;
            _mapper = mapper;
        }
        public async Task<AddProductTypeRes> AddProductType(AddProductTypeReq request)
        {
            var entity = _mapper.Map<ProductTypeEntity>(request);
            await _productTypeRepo.Add(entity);
            await _productTypeRepo.Save();
            return _mapper.Map<AddProductTypeRes>(entity);

        }
        public async Task<List<GetProductTypes>> GetAllTypes()
        {
            return _mapper.Map<List<GetProductTypes>>(await _productTypeRepo.GetAll());
        }
    }
}
