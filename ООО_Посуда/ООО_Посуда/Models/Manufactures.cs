using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Manufactures
    {
        public Manufactures()
        {
            Products = new HashSet<Products>();
        }

        public int ManufactureId { get; set; }
        public string ManufactureName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
