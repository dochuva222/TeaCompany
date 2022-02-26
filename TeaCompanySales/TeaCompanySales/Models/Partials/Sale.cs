using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaCompanySales.Models
{
    public partial class Sale
    {
        public decimal TotalSum
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
