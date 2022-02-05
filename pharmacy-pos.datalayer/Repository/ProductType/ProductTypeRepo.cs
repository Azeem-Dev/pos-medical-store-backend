using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using PT = pharmacy_pos.ef.Entities.ProductType;

namespace pharmacy_pos.datalayer.Repository.ProductType
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private readonly IRepository<PT.ProductType> _productTypeRepo;

        public ProductTypeRepo(IRepository<PT.ProductType> productTypeRepo)
        {
            _productTypeRepo = productTypeRepo;
        }
        public async Task<AddProductTypeRes> AddProductType(AddProductTypeReq request)
        {
            var entity=new PT.ProductType()
            {
                TypeName=request.TypeName
            };

            await _productTypeRepo.Add(entity);
            if (entity.Id != null)
            {
                await _productTypeRepo.Save();
            }
            return new AddProductTypeRes
            {
                Id = entity.Id.ToString(),
                TypeName = entity.TypeName,
            };

        }
    }
}
