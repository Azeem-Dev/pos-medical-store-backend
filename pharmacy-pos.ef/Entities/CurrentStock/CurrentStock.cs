using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_pos.ef.Entities.CurrentStock
{
    public class CurrentStock
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public long AvailableStock { get; set; }
    }
}
