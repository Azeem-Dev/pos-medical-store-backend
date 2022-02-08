using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.SaleItem
{
    public class SaleItem
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductSalePrice { get; set; }
        public int QuantitySold { get; set; }
        public double DiscountAmount { get; set; }
        public double ItemTotal { get; set; }
        public SaleHistory.SaleHistory Sale { get; set; }
        public Guid SaleId { get; set; }
    }
}
