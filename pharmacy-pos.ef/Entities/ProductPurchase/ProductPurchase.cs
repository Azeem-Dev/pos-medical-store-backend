using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.ProductPurchase
{
    public class ProductPurchase
    {
        public Guid Id { get; set; }
        public Supplier.Supplier Supplier { get; set; }
        public string InvoiceNumber { get; set; }
        public string PurchaseDate { get; set; }
        public List<PurchaseItem.PurchaseItem> PurchaseItems { get; set; }

    }
}
