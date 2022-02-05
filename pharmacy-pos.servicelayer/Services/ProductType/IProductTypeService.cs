using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using PT = pharmacy_pos.ef.Entities.ProductType;
namespace pharmacy_pos.servicelayer.Services.ProductType
{
    public interface IProductTypeService
    {
        Task<AddProductTypeRes> AddProductType(AddProductTypeReq req);   
    }
}
