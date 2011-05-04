using System.Collections.Generic;
using PizzaStoreFranchise.Ingredients;
using PizzaStoreFranchise.Ingredients.Toppings;

namespace PizzaStoreFranchise.Pizzas
{
    class ClamPizza : Pizza
    {
        public ClamPizza(string style, IPizzaIngredientFactory pizzaIngredientFactory) : base(style, pizzaIngredientFactory) { }

        public override string Name
        {
            get { return style + " Clam Pizza"; }
        }

        protected override IEnumerable<ITopping> CreateToppings()
        {
            IEnumerable<ITopping> toppings = new List<ITopping>() { pizzaIngredientFactory.CreateClams() };
            return toppings;
        }
    }
}
