﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public Product(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}