
namespace PizzaStoreFranchise
{
    class PizzaStore
    {
        public Pizza OrderPizza()
        {
            Pizza pizza = new Pizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            Pizza.Box();

            return pizza;
        }
    }
}
