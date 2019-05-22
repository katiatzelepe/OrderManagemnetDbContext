using System;
using System.Collections.Generic;
using System.Text;

namespace BasketManagment
{
    public class BasketProduct
    {
        public int BasketId { get; set; }
        public Basket basket { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
