using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
