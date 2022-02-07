using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;

namespace pharmacy_pos.datalayer.Repository.ProductType
{
    public interface IProductTypeRepo
    {
        Task<AddProductTypeRes> AddProductType(AddProductTypeReq request);
        Task<List<GetProductTypes>> GetAllTypes();
        //Task<PT.ProductType> GetProductType(string id);

    }
}
