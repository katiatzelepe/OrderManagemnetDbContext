using System.Collections.Generic;
using System;

using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BasketManagment
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        
        public List<BasketProduct> Basketproducts { get; set; }

        public Basket()
        {
            Basketproducts = new List<BasketProduct>();
        }


    }
}



