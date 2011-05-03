
namespace PizzaStoreFranchise.Pizzas
{
    enum PizzaType
    {
        Cheese,
        Greek,
        Pepperoni
    }

    class SimplePizzaFactory
    {

        public Pizza CreatePizza(PizzaType pizzaType)
        {
            switch(pizzaType)
            {

                case PizzaType.Greek: return new GreekPizza();
                case PizzaType.Pepperoni: return new PepperoniPizza();
                case PizzaType.Cheese:
                default: return new CheesePizza();
            }
        }
    }
}
