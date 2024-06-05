using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory
{
    public class Shipper
    {
        private IShippable _id;

        IShippable[] inventory = new Product[5];
        public Product[] shopping = new Product[10]; 

        public Shipper()
        {
            inventory[0] = new Product("Baseball Glove", 3.23m);
            inventory[1] = new Product("Bicycle", 9.50m);
            inventory[2] = new Product("Crackers", .57m);
            inventory[3] = new Product("Cell Phone", 5.95m);
            inventory[4] = new Product("Lawn Mower", 24m);
        }

        public bool authenticate(string Product, decimal Amount)
        {
            _id = Check(Product, Amount);
            if(_id != null) { return true; }
            return false;
        }

        private IShippable Check(string Product , decimal Amount)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i].ProductName == Product && inventory[i].ShippingCost == Amount)
                {
                   return _id = inventory[i];
                }
            }
            return null;
        }

        public decimal Add(bool Validate, Product ID)
        {
            decimal cost = 0m;

            if (Validate != false)
            {
                for (int i = 0; i < shopping.Length; i++)
                {
                    shopping[i] = ID;

                    cost = Account(cost, ID);
                    return cost;
                }
            }
            
            return cost;
        }

        private decimal Account(decimal Amount, Product Item)
        {
              return Amount += Item.ShippingCost;
        }

    }
}
