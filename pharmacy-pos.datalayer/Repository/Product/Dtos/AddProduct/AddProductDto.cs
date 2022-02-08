using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.datalayer.Repository.Product.Dtos.AddProduct
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public int PackQuantity { get; set; }
        public double PackCostPrice { get; set; }
        public double PackRetailPrice { get; set; }
        public string RackNumber { get; set; }
        public string Manufactorer { get; set; }
        public string Batch { get; set; }
        public string ExpiryDate { get; set; }
        public string ProductTypeId { get; set; }
    }
}
