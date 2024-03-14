namespace BuilderZad3.Interfaces
{
    public interface IPizzaBuilder
    {
        public void AddDough();
        public void AddMeat();
        public void AddCheese();
        public void AddVegetables();
        public void AddSpices();
        public IPizza GetPizza();
    }
}