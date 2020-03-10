using System;

namespace AbstractFactory
{
    /// <summary>
    /// The abstract factory pattern provides a way to encapsulate a group of individual 
    /// factories that have a common theme without specifying their concrete classes. In 
    /// normal usage, the client software creates a concrete implementation of the 
    /// abstract factory and then uses the generic interface of the factory to create 
    /// the concrete objects that are part of the theme. The client doesn't know (or care)
    /// which concrete objects it gets from each of these internal factories, since it 
    /// uses only the generic interfaces of their products.
    /// 
    /// The  Abstract Factory Pattern provides an interface (IHotDrinkFactory in this 
    /// case) for creating families of related or dependent objects (hot drinks in this 
    /// case) without specifying their concrete classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink();
        }
    }
}
