using System.Collections.Generic;
using PizzaStoreFranchise.Ingredients;
using PizzaStoreFranchise.Ingredients.Toppings;

namespace PizzaStoreFranchise.Pizzas
{
    class CheesePizza : Pizza
    {
        public CheesePizza(string style, IPizzaIngredientFactory pizzaIngredientFactory) : base(style, pizzaIngredientFactory) { }
        public override string Name
        {
            get { return style + " Cheese Pizza"; }
        }

        protected override IEnumerable<ITopping> CreateToppings()
        {
            IEnumerable<ITopping> toppings = new List<ITopping>();
            return toppings;
        }
    }
}
