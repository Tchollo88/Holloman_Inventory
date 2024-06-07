using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory

    /* I need to figure out what this class is needed for and how to implement it into the code. I need to build and mangae the add method.*/
{
    public class Shipper
    {
        #region **Instant Data **
        //holds the curent and over all balance of the products.
        private decimal _totalCost;
        private decimal _amount;

        //Tracks the change in plurality of the names of products.
        private string _n1 = "Bicycle";
        private string _n2 = "Lawn Mower";
        private string _n3 = "Baseball Glove";
        private string _n4 = "Crackers";
        private string _n5 = "Cell Phone";

        //Tracks the total balance for the stack of each item.
        private decimal _t1 = 0m;
        private decimal _t2 = 0m;
        private decimal _t3 = 0m;
        private decimal _t4 = 0m;
        private decimal _t5 = 0m;

        //Used to track the total amount of items in the chopping cart.
        private int _qty;

        // Track the size of stacks of each type of item.
        private int _c1;
        private int _c2;
        private int _c3;
        private int _c4;
        private int _c5;
        #endregion

        // Builds the Array used to store item in the shopping cart.
        public IShippable[] manifesto = new IShippable[10];

        #region ** Constructor **
        public Shipper(IShippable Obj)
        {
            
        }
        #endregion

        #region ** Essential Methods **
        //Adds items to the Manifesto Array.
        public void Add(IShippable Obj)
        {

            Total(Obj);

            for (int i = 0; i < manifesto.Length; i++)
            {
                manifesto[i] = Obj;
            }

        }

        //Calaculates Manifestos total amount. 
        public decimal Mathmatic(IShippable Obj)
        {
            _totalCost = _t1 + _t2 + _t3 + _t4 + _t5;
            return _totalCost;
        }

        //Tracks the count in each item type group.
        public int Count(IShippable Obj)
        {
            int count = 0;
            if(Obj.ProductName == "Bicycle")
            {
                count = _c1++;
                return count;
            }
            else if (Obj.ProductName == "Lawn Mower")
            {
                count = _c2++;
                return count;
            }
            else if (Obj.ProductName == "Baseball Glove")
            {
                count = _c3++;
                return count;
            }
            else if (Obj.ProductName == "Crackers")
            {
                count = _c4++;
                return count;
            }
            else if (Obj.ProductName == "Cell Phone")
            {
                count = _c5++;
                return count;
            }
            return count;
        }

        //Builds manifesto from stored variables in instant data.
        public string PrintReciept(string manifesto)
        {
            manifesto =
                _c3 + " " + _n3 + " $" + _t3 + "\n" +
                _c1 + " " + _n1 + " $" + _t1 + "\n" +
                _c5 + " " + _n5 + " $" + _t5 + "\n" +
                _c4 + " " + _n4 + " $" + _t4 + "\n" +
                _c2 + " " + _n2 + " $" + _t2 + "\n";

            return manifesto;
        }
        #endregion

        #region ** Quality of Life Methods**
        //Check the total count of items in the shopping cart.
        public bool QuantityCheck()
        {
            _qty = _c1 + _c2 + _c3 + _c4 + _c5;

            if (_qty < 11)
            {
                return true;
            }
            if(_qty >= 0)
            {
                return true;
            }
            return false;
        }

        //Checks to see if item names need to be pluralized, if so it changes name to be plural.
        public void Disect(IShippable Obj)
        {
            if (Obj.ProductName == "Bicycle")
            {
                if (_c1 > 1)
                {
                    _n1 = _n1 + "s";
                }
            }
            else if (Obj.ProductName == "Lawn Mower")
            {
                if (_c2 > 1)
                {
                    _n2 = _n2 + "s";
                }
            }
            else if (Obj.ProductName == "Baseball Glove")
            {
                if (_c3 > 1)
                {
                    _n3 = _n3 + "s";
                }
            }
            else if (Obj.ProductName == "Cell Phone")
            {
                if (_c5 > 1)
                {
                    _n5 = _n5 + "s";
                }
            }
        }

        //Resets the vairables for a fresh restart.
        public void ClearOut()
        {
            _c1 = 0;
            _c2 = 0;
            _c3 = 0;
            _c4 = 0;
            _c5 = 0;

            _t1 = 0m;
            _t2 = 0m;
            _t3 = 0m;
            _t4 = 0m;
            _t5 = 0m;

            _totalCost = 0m;
            _amount = 0m;

            _n1 = "Bicycle";
            _n2 = "Lawn Mower";
            _n3 = "Baseball Glove";
            _n4 = "Crackers";
            _n5 = "Cell Phone";

        }

        // Passes a value to the _amount variable .
        public void Total(IShippable Obj)
        {
            _amount = Obj.ShippingCost;
        }

        //Accumlates the total amount in each product stack
        public void AccumulateStackTotal(IShippable Obj)
        {
            decimal total;
            total = _amount;

            if (Obj.ProductName == "Bicycle")
            {
                _t1 = Convert.ToDecimal(_c1) * total;
                _totalCost = _t1;
            }
            else if (Obj.ProductName == "Lawn Mower")
            {
                _t2 = Convert.ToDecimal(_c2) * total;
                _totalCost = _t2;
            }
            else if (Obj.ProductName == "Baseball Glove")
            {
                _t3 = Convert.ToDecimal(_c3) * total;
                _totalCost = _t3;
            }
            else if (Obj.ProductName == "Crackers")
            {
                _t4 = Convert.ToDecimal(_c4) * total;
                _totalCost = _t4;
            }
            else if (Obj.ProductName == "Cell Phone")
            {
                _t5 = Convert.ToDecimal(_c5) * total;
                _totalCost = _t5;
            }
        }
        #endregion
    }

}
