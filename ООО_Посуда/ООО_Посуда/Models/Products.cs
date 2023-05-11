using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Products
    {
        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? ProductCategory { get; set; }
        public byte[] ProductPhoto { get; set; }
        public int? ProductManufacturer { get; set; }
        public decimal? ProductCost { get; set; }
        public int? ProductUnit { get; set; }
        public sbyte? ProductDiscountAmount { get; set; }
        public sbyte? ProductDiscount { get; set; }
        public int? ProductSupplier { get; set; }
        public int? ProductQuantityInStock { get; set; }
        public string ProductStatus { get; set; }

        public virtual Categories ProductCategoryNavigation { get; set; }
        public virtual Manufactures ProductManufacturerNavigation { get; set; }
        public virtual Suppliers ProductSupplierNavigation { get; set; }
        public virtual Units ProductUnitNavigation { get; set; }
    }
}
