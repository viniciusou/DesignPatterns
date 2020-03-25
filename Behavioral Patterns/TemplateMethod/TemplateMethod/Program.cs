using System;
using TemplateMethod.Classes;

namespace TemplateMethod
{
    /// <summary>
    /// The template method is a method in a superclass, usually an abstract superclass, 
    /// and defines the skeleton of an operation in terms of a number of high-level steps. 
    /// These steps are themselves implemented by additional helper methods in the same 
    /// class as the template method. The helper methods may be either abstract methods, 
    /// for which case subclasses are required to provide concrete implementations, or hook 
    /// methods, which have empty bodies in the superclass. This pattern is an example of 
    /// inversion of control because the high-level code no longer determines what algorithms 
    /// to run; a lower-level algorithm is instead selected at run-time. 
    /// 
    /// The template method allows us to define the 'skeleton' of the algorithm, with concrete
    /// implementations defined in subclasses.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());
        }
    }
}
