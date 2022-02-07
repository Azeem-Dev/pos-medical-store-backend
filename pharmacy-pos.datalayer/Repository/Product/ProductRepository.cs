using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductEntity = pharmacy_pos.ef.Entities.Product.Product;

namespace pharmacy_pos.datalayer.Repository.Product
{
    public class ProductRepository:IProductRepository
    {
        private readonly IRepository<ProductEntity> _productRepo;

        public ProductRepository(IRepository<ProductEntity> productRepo)
        {
            _productRepo = productRepo;
        }

    }
}
