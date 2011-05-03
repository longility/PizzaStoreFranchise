using System;

namespace PizzaStoreFranchise.Pizzas.ChicagoStyle
{
    abstract class ChicagoStylePizza : Pizza
    {
        protected sealed override string Dough
        {
            get { return "Thick Crust Dough"; }
        }

        internal override void Cut()
        {
            Console.Out.WriteLine("Cutting the pizza into square slices.");
        }
    }
}
