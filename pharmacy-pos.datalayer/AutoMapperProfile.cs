using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTypeEntity = pharmacy_pos.ef.Entities.ProductType.ProductType;
using ProductEntity = pharmacy_pos.ef.Entities.Product.Product;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
using pharmacy_pos.datalayer.Repository.Product.Dtos;
using pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct;

namespace pharmacy_pos.datalayer
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<LinkEntity, LinkResponseDto>().ForMember(c => c.Categories, c => c.MapFrom(c => c.LinkCategories.Select(c => c.Category))).ReverseMap();
            #region ProducType Entity mappings
            CreateMap<AddProductTypeReq, ProductTypeEntity>();
            CreateMap<ProductTypeEntity, AddProductTypeRes>();
            CreateMap<ProductTypeEntity, GetProductTypes>().ReverseMap();
            #endregion

            #region Product Entity mappings
            CreateMap<ProductEntity, ProductBaseDto>().ForMember
                                                (
                                                    c => c.ProductType, d => d.MapFrom<ProductTypeEntity>(e => e.ProductType)
                                                ).ReverseMap();
            CreateMap<AddProductDto, ProductEntity>().ForMember
                                                (
                                                    c => c.ProductTypeId, d => d.MapFrom<string>(e => e.ProductTypeId)
                                                );
            #endregion
        }
    }
}
