using System;
using System.Collections.Generic;

namespace PizzaStoreFranchise.Pizzas
{
    abstract class Pizza
    {
        public abstract string Name { get; }
        protected abstract string Dough { get; }
        protected abstract string Sauce { get; }
        protected abstract IEnumerable<string> Toppings { get; }

        internal void Prepare()
        {
            Console.Out.WriteLine(String.Format("Preparing {0}.", Name));
            Console.Out.WriteLine("Tossing dough...");
            Console.Out.WriteLine("Adding sauce ...");
            Console.Out.WriteLine("Adding toppings: ");

            foreach(var topping in Toppings)
            {
                Console.Out.WriteLine(String.Format("   {0}", topping));
            }
        }

        internal void Bake()
        {
            Console.Out.WriteLine("Bake for 25 minutes at 350 degrees.");
        }

        internal virtual void Cut()
        {
            Console.Out.WriteLine("Cutting the pizza into diagonal slices.");
        }

        internal static void Box()
        {
            Console.Out.WriteLine("Place pizza in official PizzaStore box.");
        }
    }
}
