using System.Collections.Generic;
using PizzaStoreFranchise.Ingredients;
using PizzaStoreFranchise.Ingredients.Toppings;

namespace PizzaStoreFranchise.Pizzas
{
    class VeggiePizza : Pizza
    {
        public VeggiePizza(string style, IPizzaIngredientFactory pizzaIngredientFactory) : base(style, pizzaIngredientFactory) { }
        public override string Name
        {
            get { return style + " Veggie Pizza"; }
        }

        protected override IEnumerable<ITopping> CreateToppings()
        {
            return pizzaIngredientFactory.CreateVeggies();
        }
    }
}
