using System;

namespace Adapter
{
    /// <summary>
    /// Adapter allows the interface of an existing class to be used as another interface.
    /// It is often used to make existing classes work with others without modifying their 
    /// source code.
    /// 
    /// An adapter allows two incompatible interfaces to work together. The key idea in 
    /// this pattern is to work through a separate adapter that adapts the interface of 
    /// an (already existing) class without changing it. 
    /// In the example you do not need to change Square class to use IRectangle interface.
    /// You create a SquareToRectangleAdapter instead.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square { Side = 4 };
            IRectangle squareToRectangleAdapter = new SquareToRectangleAdapter(square);
            Console.WriteLine($"Area of square with side {square.Side}: " +
                $"{squareToRectangleAdapter.Area()}");
        }
    }
}
