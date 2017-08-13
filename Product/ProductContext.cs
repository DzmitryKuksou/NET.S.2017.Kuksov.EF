using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity;

namespace Products
{
    /// <summary>
    /// class Productcontex for editing bd
    /// </summary>
    public partial class ProductContext : DbContext
    {
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TypeProduct> TypeProducts { get; set; }
        public virtual DbSet<NumberProduct> NumberProducts { get; set; }
    }
}
