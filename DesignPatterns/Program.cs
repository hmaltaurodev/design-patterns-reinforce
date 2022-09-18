using DesignPatterns.DecoratorPattern;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns\r\n");

            DecoratorExample.Execute();

            Console.WriteLine("\r\nPress any key to end execution");
            Console.ReadKey();
        }
    }
}
