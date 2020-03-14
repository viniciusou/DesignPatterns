using Decorator.Decorators;
using Decorator.Shapes;
using System;

namespace Decorator
{
    /// <summary>
    /// The decorator pattern is a design pattern that allows behavior to be added to an 
    /// individual object, dynamically, without affecting the behavior of other objects 
    /// from the same class. It is often useful for adhering to the Single Responsibility 
    /// Principle, as it allows functionality to be divided between classes with unique 
    /// areas of concern.
    /// 
    /// Facilitates the addition of behaviors to individual objects without inheriting
    /// from them. In this case the circle and square shapes gain additional behaviors
    /// through the ColoredShape and TransparentShape decorators.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(10);
            Console.WriteLine(square.AsString());

            var redSquare = new ColoredShape(square, "red");
            Console.WriteLine(redSquare.AsString());

            var redHalfTransparentSquare = new TransparentShape(redSquare, 0.5f);
            Console.WriteLine(redHalfTransparentSquare.AsString());
        }
    }
}
