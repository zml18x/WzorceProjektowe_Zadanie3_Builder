using BuilderZad3.Interfaces;

namespace BuilderZad3.Models
{
    public class PizzaClient : IPizzaClient
    {
        public IPizza MakePizza(IPizzaBuilder pizzaBuilder)
        {
            var pizzaDirector = new PizzaDirector(pizzaBuilder);
            pizzaDirector.ConstructPizza();

            return pizzaBuilder.GetPizza();
        }
    }
}