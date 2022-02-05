using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;

namespace pharmacy_pos.datalayer.Repository.ProductType
{
    public interface IProductTypeRepo
    {
        Task<AddProductTypeRes> AddProductType(AddProductTypeReq request);
        //Task<PT.ProductType> GetProductType(string id);

    }
}
