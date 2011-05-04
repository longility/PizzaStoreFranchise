using PizzaStoreFranchise.Ingredients;
using PizzaStoreFranchise.Pizzas;

namespace PizzaStoreFranchise.PizzaStores
{
    class NyStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            IPizzaIngredientFactory pizzaIngredientFactory = new NyPizzaIngredientFactory();
            string style = "NY Style";
            switch(pizzaType)
            {
                case PizzaType.Clam: return new ClamPizza(style, pizzaIngredientFactory);
                case PizzaType.Veggie: return new VeggiePizza(style, pizzaIngredientFactory);
                case PizzaType.Cheese:
                default: return new CheesePizza(style, pizzaIngredientFactory);
            }
        }
    }
}
