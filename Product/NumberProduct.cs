using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    /// <summary>
    /// class for purchasing
    /// </summary>
    public class NumberProduct
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
