using PizzaStoreFranchise.Pizzas;
using PizzaStoreFranchise.Pizzas.NyStyle;

namespace PizzaStoreFranchise.PizzaStores
{
    class NyStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            switch(pizzaType)
            {
                case PizzaType.Greek: return new NyStyleGreekPizza();
                case PizzaType.Pepperoni: return new NyStylePepperoniPizza();
                case PizzaType.Cheese:
                default: return new NyStyleCheesePizza();
            }
        }
    }
}
