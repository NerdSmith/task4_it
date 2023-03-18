﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_it
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual double GetQuality()
        {
            return Price / Quantity;
        }

        public override string? ToString()
        {
            return $"Product: {Name}, price = {Price}, quantity = {Quantity}, Q = {GetQuality()}";
        }
    }
}
