using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory
{
    public class Shipper
    {
        public Product[] inventory = new Product[5];

        public Shipper()
        {
            inventory[0] = new Product("Baseball Glove", 3.23m);
            inventory[1] = new Product("Bicycle", 9.50m);
            inventory[2] = new Product("Crackers", .57m);
            inventory[3] = new Product("Cell Phone", 5.95m);
            inventory[4] = new Product("Lawn Mower", 24m);
        }


    }
}
