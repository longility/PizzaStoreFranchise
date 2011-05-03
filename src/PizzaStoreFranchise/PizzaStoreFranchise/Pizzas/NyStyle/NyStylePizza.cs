
namespace PizzaStoreFranchise.Pizzas.NyStyle
{
    abstract class NyStylePizza : Pizza
    {
        protected sealed override string Dough
        {
            get { return "Thin Crust Dough"; }
        }
    }
}
