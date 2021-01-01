using System;

namespace EntityFExample.Models
{
    class Order : Entity
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public bool IsCancelled { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
