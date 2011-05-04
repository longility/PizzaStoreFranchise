using System;
using PizzaStoreFranchise.PizzaStores;

namespace PizzaStoreFranchise
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNyPizzaStore();
            Console.Out.WriteLine();
            PrintChicagoPizzaStore();
        }

        private static void PrintChicagoPizzaStore()
        {
            PizzaStore pizzaStore = new ChicagoStylePizzaStore();
            pizzaStore.OrderPizza(PizzaType.Cheese);
            Console.Out.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Clam);
            Console.Out.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Veggie);
        }

        private static void PrintNyPizzaStore()
        {
            PizzaStore pizzaStore = new NyStylePizzaStore();
            pizzaStore.OrderPizza(PizzaType.Cheese);
            Console.Out.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Clam);
            Console.Out.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Veggie);
        }
    }
}
