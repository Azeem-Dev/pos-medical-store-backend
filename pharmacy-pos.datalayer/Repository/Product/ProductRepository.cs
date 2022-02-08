using AutoMapper;
using Microsoft.EntityFrameworkCore;
using pharmacy_pos.datalayer.Repository.Product.Dtos;
using pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct;
using pharmacy_pos.ef.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductEntity = pharmacy_pos.ef.Entities.Product.Product;

namespace pharmacy_pos.datalayer.Repository.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly IRepository<ProductEntity> _productRepo;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public ProductRepository(IRepository<ProductEntity> productRepo, IMapper mapper,DataContext context)
        {
            _productRepo = productRepo;
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<ProductBaseDto>> GetAllProducts()
            => _mapper.Map<List<ProductBaseDto>>(await _context.Set<ProductEntity>().Include(c => c.ProductType).ToListAsync());
        public async Task<bool> AddProduct(AddProductDto product)
        {
            var entity = new ProductEntity
            {
                Name = product.Name,
                PackQuantity = product.PackQuantity,
                PackCostPrice = product.PackCostPrice,
                PackRetailPrice = product.PackRetailPrice,
                RackNumber = product.RackNumber,
                Manufactorer = product.Manufactorer,
                Batch = product.Batch,
                ExpiryDate = product.ExpiryDate,
                ProductTypeId = Guid.Parse(product.ProductTypeId)

            };
            var res= await _productRepo.Add(entity);
            await _productRepo.Save();
            return Task.CompletedTask.IsCompleted;
        }

    }
}
