
using PizzaStoreFranchise.Pizzas;

namespace PizzaStoreFranchise.PizzaStores
{
    enum PizzaType
    {
        Cheese,
        Greek,
        Pepperoni
    }

    abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            Pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaType pizzaType);
    }
}
