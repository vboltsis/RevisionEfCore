using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFExample.Models
{
    class Customer : Entity
    {
        //data annotations
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public List<Order> Orders { get; set; }
    }
}
