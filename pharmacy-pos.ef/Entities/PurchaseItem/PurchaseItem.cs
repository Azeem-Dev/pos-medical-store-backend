using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.PurchaseItem
{
    public class PurchaseItem
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBatch { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductExpiry { get; set; }
        public double ProductRetailPrice { get; set; }
        public double ProductTradePrice { get; set; }
        public double Percentage { get; set; }
        public double ProductTotal { get; set; }
        public ProductPurchase.ProductPurchase Purchase { get; set; }
        public Guid PurchaseId { get; set; }

    }
}
