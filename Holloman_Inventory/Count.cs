using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holloman_Inventory
{
    public class Count
    {
		private int _count;

		public int Declare()
		{
			return _count;
		}

		public int Increse() { return _count++; }
		public int Build { get; set; }

	}
}
