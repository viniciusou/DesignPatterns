using Mediator.Components;
using System;

namespace Mediator
{
    /// <summary>
    /// The mediator pattern defines an object that encapsulates how a set of objects interact.
    /// With the mediator pattern, communication between objects is encapsulated within a 
    /// mediator object. Objects no longer communicate directly with each other, but instead 
    /// communicate through the mediator. This reduces the dependencies between communicating 
    /// objects, thereby reducing coupling.
    /// 
    /// In this case the Mediator interface declares a method used by components to notify the
    //  mediator about various events. The Mediator may react to these events and pass the 
    //  execution to other components.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
