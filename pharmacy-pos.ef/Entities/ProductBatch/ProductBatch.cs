using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.ProductBatch
{
    public class ProductBatch
    {
        public Guid Id { get; set; }
        public string BatchNumber { get; set; }
        public string ExpiryDate { get; set; }
        public long BatchStock { get; set; }
        public Product.Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
