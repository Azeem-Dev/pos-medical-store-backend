using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.Supplier
{
    public class Supplier
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public List<ProductPurchase.ProductPurchase> Purchases { get; set; }
    }
}
