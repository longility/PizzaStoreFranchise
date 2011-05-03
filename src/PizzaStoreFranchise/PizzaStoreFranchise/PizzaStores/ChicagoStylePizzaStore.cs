using PizzaStoreFranchise.Pizzas;
using PizzaStoreFranchise.Pizzas.ChicagoStyle;

namespace PizzaStoreFranchise.PizzaStores
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            switch(pizzaType)
            {
                case PizzaType.Greek: return new ChicagoStyleGreekPizza();
                case PizzaType.Pepperoni: return new ChicagoStylePepperoniPizza();
                case PizzaType.Cheese:
                default: return new ChicagoStyleCheesePizza();
            }
        }
    }
}
