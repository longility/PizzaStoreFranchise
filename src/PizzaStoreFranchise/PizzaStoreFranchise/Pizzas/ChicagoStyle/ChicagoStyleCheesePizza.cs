
using System.Collections.Generic;
namespace PizzaStoreFranchise.Pizzas.ChicagoStyle
{
    class ChicagoStyleCheesePizza : ChicagoStylePizza
    {
        List<string> toppings = new List<string>();

        public ChicagoStyleCheesePizza()
        {
            toppings.Add("Mozarella Cheese");
            toppings.Add("Parmesan Cheese");
        }
        public override string Name
        {
            get { return "Chicago Style Cheese Pizza"; }
        }

        protected override string Sauce
        {
            get { return "Plum Tomato Sauce"; }
        }

        protected override IEnumerable<string> Toppings
        {
            get { return toppings; }
        }
    }
}
