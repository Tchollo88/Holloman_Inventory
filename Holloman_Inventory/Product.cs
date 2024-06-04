using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory
{
    public class Product : IShippable
    {
        private decimal _shipping;
        private string _product;

        public Product(string Name, decimal Shipping)
        {
            _product = Name;
            _shipping = Shipping;
        }

        public decimal ShippingCost { get { return _shipping; } }

       string IShippable.ProductName { get { return _product; } }
    }
}
