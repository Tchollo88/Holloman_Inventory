﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory
{
    public class BaseballGlove : IShippable
    {
        private decimal _shipping;
        private string _product;

        public BaseballGlove(string Name, decimal Shipping)
        {
            _product = Name;
            _shipping = Shipping;
        }

        public decimal ShippingCost { get { return _shipping; } }

        public string ProductName
        {
            get { return _product; }
        }
    }
}
