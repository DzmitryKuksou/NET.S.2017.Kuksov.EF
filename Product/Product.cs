using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    /// <summary>
    /// class product
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public byte Image { get; set; }
        public virtual TypeProduct Type { get; set; }
        public string Characteristic { get; set; }
    }
}
