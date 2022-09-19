using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    // Concrete Decorator of Cheese
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        { }

        public override string GetPizzaType()
        {
            return $"{base.GetPizzaType()}\r\n with extra cheese";
        }
    }
}
