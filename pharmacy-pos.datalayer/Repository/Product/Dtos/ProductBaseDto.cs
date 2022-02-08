using pharmacy_pos.datalayer.Repository.ProductType.Dtos.GetProductType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.datalayer.Repository.Product.Dtos
{
    public class ProductBaseDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int PackQuantity { get; set; }
        public double PackCostPrice { get; set; }
        public double PackRetailPrice { get; set; }
        public string RackNumber { get; set; }
        public string BarCodeNumber { get; set; }
        public string BarCodePath { get; set; }
        public string Manufactorer { get; set; }
        public string Batch { get; set; }
        public string ExpiryDate { get; set; }
        public GetProductTypes ProductType  { get; set; }
    }
}
