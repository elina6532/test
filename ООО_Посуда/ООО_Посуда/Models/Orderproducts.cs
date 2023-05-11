using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Orderproducts
    {
        public int OrderId { get; set; }
        public string ProductArticleNumber { get; set; }
        public int? OrderProductCount { get; set; }

        public virtual Orders Order { get; set; }
    }
}
