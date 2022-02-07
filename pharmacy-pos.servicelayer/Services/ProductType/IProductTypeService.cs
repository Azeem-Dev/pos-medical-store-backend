using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
namespace pharmacy_pos.servicelayer.Services.ProductType
{
    public interface IProductTypeService
    {
        Task<AddProductTypeRes> AddProductType(AddProductTypeReq req);
        Task<List<GetProductTypes>> GetAllTypes();
    }
}
