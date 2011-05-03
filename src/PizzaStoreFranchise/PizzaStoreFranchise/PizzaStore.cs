
using PizzaStoreFranchise.Pizzas;
namespace PizzaStoreFranchise
{
    class PizzaStore
    {
        private readonly SimplePizzaFactory pizzaFactory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            Pizza.Box();

            return pizza;
        }
    }
}
