
using System.Collections.Generic;
namespace PizzaStoreFranchise.Pizzas.ChicagoStyle
{
    class ChicagoStylePepperoniPizza : ChicagoStylePizza
    {
        List<string> toppings = new List<string>();

        public ChicagoStylePepperoniPizza()
        {
            toppings.Add("Mozarella Cheese");
            toppings.Add("Parmesan Cheese");
            toppings.Add("Pepperoni");
        }

        public override string Name
        {
            get { return "Chicago Style Pepperoni Pizza"; }
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
