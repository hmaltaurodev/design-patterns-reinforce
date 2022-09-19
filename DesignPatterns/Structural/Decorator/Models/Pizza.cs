using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.Models
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a standard pizza";
        }
    }
}
