using System;
using System.Collections.Generic;
using PizzaStoreFranchise.Ingredients;
using PizzaStoreFranchise.Ingredients.Cheeses;
using PizzaStoreFranchise.Ingredients.Doughs;
using PizzaStoreFranchise.Ingredients.Sauces;
using PizzaStoreFranchise.Ingredients.Toppings;

namespace PizzaStoreFranchise.Pizzas
{
    abstract class Pizza
    {
        protected readonly IPizzaIngredientFactory pizzaIngredientFactory;
        protected readonly string style;

        private IDough dough;
        private IEnumerable<ICheese> cheeses;
        private ISauce sauce;
        private IEnumerable<ITopping> toppings;

        public Pizza(string style, IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this.style = style;
            this.pizzaIngredientFactory = pizzaIngredientFactory;

        }

        public abstract string Name { get; }

        protected abstract IEnumerable<ITopping> CreateToppings();

        internal void Prepare()
        {
            Console.Out.WriteLine(String.Format("Preparing {0}.", Name));

            this.dough = pizzaIngredientFactory.CreateDough();
            this.cheeses = pizzaIngredientFactory.CreateCheeses();
            this.sauce = pizzaIngredientFactory.CreateSauce();
            this.toppings = CreateToppings();

            Console.Out.WriteLine("Tossing dough...");
            Console.Out.WriteLine("Adding sauce ...");
            Console.Out.WriteLine("Adding toppings: ");

            foreach(var topping in toppings)
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
