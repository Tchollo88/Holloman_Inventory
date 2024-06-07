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
        private decimal _totalCost;
        private decimal _amount;

        private string _n1 = "Bicycle";
        private string _n2 = "Lawn Mower";
        private string _n3 = "Baseball Glove";
        private string _n4 = "Crackers";
        private string _n5 = "Cell Phone";

        private decimal _t1 = 0m;
        private decimal _t2 = 0m;
        private decimal _t3 = 0m;
        private decimal _t4 = 0m;
        private decimal _t5 = 0m;

        private int _qty;

        private int _c1;
        private int _c2;
        private int _c3;
        private int _c4;
        private int _c5;


        public IShippable[] manifesto = new IShippable[10];

        public Shipper(IShippable Obj)
        {
            
        }

        public string Add(IShippable Obj)
        {

            _amount = Obj.ShippingCost;
            string product = Obj.ProductName + " " + Obj.ShippingCost;

            for (int i = 0; i < manifesto.Length; i++)
            {
                manifesto[i] = Obj;
            }
            return product;

        }

        public decimal Mathmatic(IShippable Obj)
        {
            decimal total;
            total = _amount;

            if (Obj.ProductName == "Bicycle")
            {
                _t1 = Convert.ToDecimal(_c1) * total;
                _totalCost = _t1;
                return _totalCost;
            }
            else if (Obj.ProductName == "Lawn Mower")
            {
                _t2 = Convert.ToDecimal(_c2) * total;
                _totalCost = _t2;
                return _totalCost;
            }
            else if (Obj.ProductName == "Baseball Glove")
            {
                _t3 = Convert.ToDecimal(_c3) * total;
                _totalCost = _t3;
                return _totalCost;
            }
            else if (Obj.ProductName == "Crackers")
            {
                _t4 = Convert.ToDecimal(_c4) * total;
                _totalCost = _t4;
                return _totalCost;
            }
            else if (Obj.ProductName == "Cell Phone")
            {
                _t5 = Convert.ToDecimal(_c5) * total;
                _totalCost = _t5;
                return _totalCost;
            }
            _totalCost = _t1 + _t2 + _t3 + _t4 + _t5;
            return _totalCost;
        }

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

        public void Disect(IShippable Obj)
        {
            if (Obj.ProductName == "Bicycle")
            {
                if (_c1 > 1)
                {
                    _n1 = _n1 + "s";
                }
            }
            else if(Obj.ProductName == "Lawn Mower")
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
    }
    
}
