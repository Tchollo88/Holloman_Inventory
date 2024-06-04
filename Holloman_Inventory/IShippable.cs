using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory
{
    internal interface IShippable
    {
        decimal ShippingCost { get; }

        string ProductName { get; }
    }
}
