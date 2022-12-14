using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    // Base Decorator
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }
}
