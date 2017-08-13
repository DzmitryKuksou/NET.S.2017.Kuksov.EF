using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    /// <summary>
    /// Purchase
    /// </summary>
    public class Purchase
    {
        public int Id { get; set; }
        public virtual List<NumberProduct> NumberProducts { get; set; }
    }
}
