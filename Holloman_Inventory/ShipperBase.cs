namespace Holloman_Inventory
{
    public class ShipperBase
    {
        private IShippable _id;

        public decimal Add(bool Validate, IShippable ID)
        {
            decimal cost = 0m;

            if (Validate != false)
            {
                for (int i = 0; i < shopping.Length; i++)
                {
                    shopping[i] = Item;

                    cost = Account(cost, Item);
                    return cost;
                }
            }

            return cost;
        }
    }
}