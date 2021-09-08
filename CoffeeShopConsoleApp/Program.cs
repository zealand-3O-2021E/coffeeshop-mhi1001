using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Cortado(5),
                new Latte(3),
                new Latte(4),
                new Latte(1),
                new BlackCoffee(4)

            };
            //a list for the coffees with milk
            List<IMilk> milkOrderList = new List<IMilk>();

            foreach (Coffee coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price());
                Console.WriteLine($"the Strength of the coffee is: {coffee.Strength()}");
                
                if (coffee is IMilk) //if the class in question
                                     //is IMilk, (it is, since it inherits from IMilk)
                {
                    //!!!!!will treat coffee AS a interface!!!!!,
                    //thus since IMilk is for any coffee that has milk,
                    //it will successfully add all the milk coffees to the list
                    milkOrderList.Add(coffee as IMilk); //
                }
            }


            Console.WriteLine($"Milk Order List has a total of: {milkOrderList.Count} coffees");

        }
    }
}
