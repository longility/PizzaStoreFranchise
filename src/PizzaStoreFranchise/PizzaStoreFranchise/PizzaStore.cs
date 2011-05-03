
using PizzaStoreFranchise.Pizzas;
namespace PizzaStoreFranchise
{
    class PizzaStore
    {
        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza;
            switch(type)
            {
                case PizzaType.Cheese: pizza = new CheesePizza(); break;
                case PizzaType.Greek: pizza = new GreekPizza(); break;
                case PizzaType.Pepperoni: pizza = new PepperoniPizza(); break;
                default: pizza = new CheesePizza(); break;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            Pizza.Box();

            return pizza;
        }
    }
}
