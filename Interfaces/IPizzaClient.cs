namespace BuilderZad3.Interfaces
{
    public interface IPizzaClient
    {
        public IPizza MakePizza(IPizzaBuilder pizzaBuilder);
    }
}