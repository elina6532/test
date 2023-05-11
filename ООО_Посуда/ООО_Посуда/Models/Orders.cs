using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Orderproducts = new HashSet<Orderproducts>();
        }

        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public int OrderPickupPoint { get; set; }
        public int OrderClient { get; set; }
        public int OrderCode { get; set; }

        public virtual Users OrderClientNavigation { get; set; }
        public virtual Pickuppoints OrderPickupPointNavigation { get; set; }
        public virtual ICollection<Orderproducts> Orderproducts { get; set; }
    }
}
