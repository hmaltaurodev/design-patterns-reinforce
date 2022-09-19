using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    // Concrete Decorator of Bacon
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        { }

        public override string GetPizzaType()
        {
            return $"{base.GetPizzaType()}\r\n with extra bacon";
        }
    }
}
