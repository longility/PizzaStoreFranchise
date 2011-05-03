
using System.Collections.Generic;
namespace PizzaStoreFranchise.Pizzas.ChicagoStyle
{
    class ChicagoStyleGreekPizza : ChicagoStylePizza
    {
        List<string> toppings = new List<string>();

        public ChicagoStyleGreekPizza()
        {
            toppings.Add("Mozarella Cheese");
            toppings.Add("Parmesan Cheese");
            toppings.Add("Gyro");
        }
        public override string Name
        {
            get { return "Chicago Style Greek Pizza"; }
        }

        protected override string Sauce
        {
            get { return "White Sauce"; }
        }

        protected override IEnumerable<string> Toppings
        {
            get { return toppings; }
        }
    }
}
