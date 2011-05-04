using PizzaStoreFranchise.Pizzas;
using PizzaStoreFranchise.Ingredients;

namespace PizzaStoreFranchise.PizzaStores
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
            string style = "Chicago Style";
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
