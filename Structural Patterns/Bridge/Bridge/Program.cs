using Bridge.Renderers;
using System;

namespace Bridge
{
    /// <summary>
    /// The bridge pattern is meant to decouple an abstraction from its implementation so 
    /// that the two can vary independently. The bridge uses encapsulation, aggregation, 
    /// and can use inheritance to separate responsibilities into different classes.
    /// 
    /// Bridge connects components together through abstractions. In this case circle
    /// can be rendered as a vector or a raster because of the abstraction.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            IRenderer rasterRenderer = new RasterRenderer();
            var circle = new Circle(rasterRenderer, 5);

            circle.Draw();
            circle.Resize(2);
            circle.Draw();

            IRenderer vectorRenderer = new VectorRenderer();
            circle = new Circle(vectorRenderer, 5);

            circle.Draw();
            circle.Resize(2);
            circle.Draw();
        }
    }
}
