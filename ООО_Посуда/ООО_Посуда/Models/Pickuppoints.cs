using System;
using System.Collections.Generic;

namespace ООО_Посуда.Models
{
    public partial class Pickuppoints
    {
        public Pickuppoints()
        {
            Orders = new HashSet<Orders>();
        }

        public int PickupPointId { get; set; }
        public int PickuppointIndex { get; set; }
        public string PickupPointAddress { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
