#region Behavioral Usings
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.Template;
using DesignPatterns.Behavioral.Visitor;
#endregion

#region Creational Usings
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
#endregion

#region Structural Usings
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.FlyWeight;
using DesignPatterns.Structural.Proxy;
#endregion

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Design Patterns");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Remember to uncomment the pattern you want to run");

            #region Behavioral Examples
            //ChainOfResponsibilityExample.Execute(); //TODO
            //CommandExample.Execute(); //TODO
            //InterpreterExample.Execute(); //TODO
            //IteratorExample.Execute(); //TODO
            //MediatorExample.Execute(); //TODO
            //MementoExample.Execute(); //TODO
            //ObserverExample.Execute();
            //StateExample.Execute(); //TODO
            //StrategyExample.Execute(); //TODO
            //TemplateExample.Execute(); //TODO
            //VisitorExample.Execute(); //TODO
            #endregion

            #region Creational Examples
            //AbstractFactoryExample.Execute(); //TODO
            //BuilderExample.Execute(); //TODO
            //FactoryExample.Execute(); //TODO
            //PrototypeExample.Execute(); //TODO
            //SingletonExample.Execute(); //TODO
            #endregion

            #region Structural Examples
            //AdapterExample.Execute(); //TODO
            //BridgeExample.Execute(); //TODO
            //CompositeExample.Execute(); //TODO
            //DecoratorExample.Execute();
            //FacadeExample.Execute(); //TODO
            //FlyWeightExample.Execute(); //TODO
            //ProxyExample.Execute(); //TODO
            #endregion

            Console.ResetColor();
            Console.WriteLine("\r\nPress any key to end execution");
            Console.ReadKey();
        }
    }
}
