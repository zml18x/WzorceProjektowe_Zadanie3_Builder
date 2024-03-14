using BuilderZad3.Enums;

namespace BuilderZad3.Interfaces
{
    public interface IPizza
    {
        public string? Name { get; set; }
        public DoughType Dough { get; set; }
        public IList<string> Meat { get; set; }
        public IList<string> Cheese { get; set; }
        public IList<string> Vegetables { get; set; }
        public IList<string> Spices { get; set; }
    }
}