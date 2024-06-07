using System.Security.Cryptography;

namespace Holloman_Inventory
{
    public class Program
    {
        IShippable item;


        static void Main(string[] args)
        {
            int qty = 0;
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int c5 = 0;

        IShippable item = new Bicycle("Bicycle", 9.50m);
            Shipper cart = new Shipper(item);        
            
            Menu(c1, c2, c3, c4, c5, cart);
        }

        public static void Menu(int c1, int c2, int c3 , int c4, int c5, Shipper cart)
        {
            decimal cost = 0;
            bool check;

            check = cart.QuantityCheck();
            
            Console.Clear();
            Console.WriteLine("Welcome to SurplusPlus, we have a multitude of items in stock please select one of the following: ");
            Console.WriteLine("Press the number corresponding with the item in question. Keep in mind you can only have 10 items at a time.");
            Console.WriteLine("(1) Bicycle");
            Console.WriteLine("(2) Lawn Mower");
            Console.WriteLine("(3) Baseball Glove");
            Console.WriteLine("(4) Crackers");
            Console.WriteLine("(5) Cell Phone");
            Console.WriteLine("(6) List Shopping Cart");
            Console.WriteLine("(7) Make Purchase");
            ConsoleKeyInfo Key = Console.ReadKey();

            if(check == true)
            {
                if (
                Key.Key != ConsoleKey.D1 &&
                Key.Key != ConsoleKey.D2 &&
                Key.Key != ConsoleKey.D3 &&
                Key.Key != ConsoleKey.D4 &&
                Key.Key != ConsoleKey.D5 &&
                Key.Key != ConsoleKey.D6 &&
                Key.Key != ConsoleKey.D7
                )
                {
                    Console.WriteLine
                        ("Sorry, you enter an invalid input. Please double check you,and enter your choice. \nPress enter to continue back to the menu....");
                    Console.ReadLine();
                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (
                    Key.Key == ConsoleKey.D1
                    )
                {
                    IShippable item = new Bicycle("Bicycle", 9.50m);
                    cart.Add(item);

                    c1 = cart.Count(item);
                    cost = cart.Mathmatic(item);
                    cart.Disect(item);

                    SubMessage(item);
                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (Key.Key == ConsoleKey.D2)
                {

                    LawnMower item = new LawnMower("Lawn Mower", 24m);
                    cart.Add(item);

                    c2 = cart.Count(item);
                    cost = cart.Mathmatic(item);
                    cart.Disect(item);

                    SubMessage(item);
                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (Key.Key == ConsoleKey.D3)
                {
                    IShippable item = new BaseballGlove("Baseball Glove", 3.23m);
                    cart.Add(item);

                    c3 = cart.Count(item);
                    cost = cart.Mathmatic(item);
                    cart.Disect(item);

                    SubMessage(item);
                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (Key.Key == ConsoleKey.D4)
                {
                    IShippable item = new Crackers("Crackers", 0.57m);
                    cart.Add(item);

                    c4 = cart.Count(item);
                    cost = cart.Mathmatic(item);

                    SubMessage(item);
                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (Key.Key == ConsoleKey.D5)
                {
                    IShippable item = new CellPhone("Cell Phone", 5.95m);
                    cart.Add(item);

                    c5 = cart.Count(item);
                    cost = cart.Mathmatic(item);
                    cart.Disect(item);

                    SubMessage(item);
                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (Key.Key == ConsoleKey.D6)
                {                                  
                    IShippable item = new Bicycle("", 0m);
                    string manifesto = "";
                    manifesto = cart.PrintReciept(manifesto);
                    cost = cart.Mathmatic(item);

                    Console.Clear();
                    Console.WriteLine("Shipment Manifest");
                    Console.WriteLine(manifesto);
                    Console.WriteLine("Total cost: $" + cost);
                    Console.WriteLine("\n" + "\n" + "Press enter to continue....");
                    Console.ReadLine();

                    Menu(c1, c2, c3, c4, c5, cart);
                }
                else if (Key.Key == ConsoleKey.D7) 
                {
                    Console.Clear();
                    IShippable item = new Bicycle("", 0);
                    cost = cart.Mathmatic(item);
                    Console.WriteLine("The total shipping cost for this order is: $" + cost);
                    Console.WriteLine("Press enter to continue ....");
                    Console.ReadLine();
                    cart.ClearOut();
                    Menu(c1, c2, c3, c4, c5, cart);
                }
            }
            else { Menu(c1, c2, c3, c4, c5, cart); }
            
        }
        
        public static void SubMessage(IShippable item)
        {
            Console.Clear();
            decimal cost = item.ShippingCost;
            Console.WriteLine
                (1 + " " +  item.ProductName + " has been added to your cart. \nPress enter to continue to the menu...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
