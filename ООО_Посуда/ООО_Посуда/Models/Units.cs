using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Units
    {
        public Units()
        {
            Products = new HashSet<Products>();
        }

        public int UnitId { get; set; }
        public string UnitName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
