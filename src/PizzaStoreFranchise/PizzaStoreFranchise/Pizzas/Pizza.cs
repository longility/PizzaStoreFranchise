using System;

namespace PizzaStoreFranchise.Pizzas
{
    abstract class Pizza
    {
        internal void Prepare()
        {
            Console.Out.WriteLine("Prepare pizza.");
        }

        internal void Bake()
        {
            Console.Out.WriteLine("Bake pizza.");
        }

        internal void Cut()
        {
            Console.Out.WriteLine("Cut pizza.");
        }

        internal static void Box()
        {
            Console.Out.WriteLine("Box pizza.");
        }
    }
}
