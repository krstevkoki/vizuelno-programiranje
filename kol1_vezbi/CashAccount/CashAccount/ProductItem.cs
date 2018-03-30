﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class ProductItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public ProductItem()
        {
        }

        public override string ToString()
        {
            return String.Format("{0} {1} x {2} = {3:.00}", Product.Name, Product.Price,
                Quantity, (Product.Price * Quantity));
        }
    }
}