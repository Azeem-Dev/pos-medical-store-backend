using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.SaleHistory
{
    public class SaleHistory
    {
        public Guid Id { get; set; }
        public List<SaleItem.SaleItem> Sales { get; set; }
    }
}
