using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTypeEntity = pharmacy_pos.ef.Entities.ProductType.ProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.AddProductType;
using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;

namespace pharmacy_pos.datalayer
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //CreateMap<CategoryResponseDto, CategoryEntity>().ReverseMap();
            //CreateMap<LinkEntity, LinkResponseDto>().ForMember(c => c.Categories, c => c.MapFrom(c => c.LinkCategories.Select(c => c.Category))).ReverseMap();
            //CreateMap<SubCategoryEntityDto, SubCategoryEntity>().ReverseMap();
            //CreateMap<CategoryEntityDto, CategoryEntity>().ReverseMap();
            //CreateMap<LinkCreateSubCategoryResponseDto, SubCategoryEntity>().ReverseMap();
            CreateMap<AddProductTypeReq, ProductTypeEntity>();
            CreateMap<ProductTypeEntity, AddProductTypeRes>();
            CreateMap<ProductTypeEntity, GetProductTypes>();
        }
    }
}
