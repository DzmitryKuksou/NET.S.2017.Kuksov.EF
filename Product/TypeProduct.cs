using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    /// <summary>
    /// Type of Product
    /// </summary>
    public class TypeProduct
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public virtual List<Product> products { get; set; }
    }
}
