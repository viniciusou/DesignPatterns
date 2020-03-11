using System;

namespace Composite
{
    /// <summary>
    /// The composite pattern is a partitioning design pattern. It describes a group of 
    /// objects that are treated the same way as a single instance of the same type of 
    /// object. The intent of a composite is to "compose" objects into tree structures 
    /// to represent part-whole hierarchies. 
    /// 
    /// Implementing the composite pattern allows treating individual objects and 
    /// aggregate objects in a uniform manner.
    /// In this case, individual graphic objects (circles and squares) are treated the 
    /// same way as lists of graphic objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var drawing = new GraphicObject { Name = "My Drawing" };
            drawing.Children.Add(new Square { Color = "Red" });
            drawing.Children.Add(new Circle { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Circle { Color = "Blue" });
            group.Children.Add(new Square { Color = "Blue" });
            drawing.Children.Add(group);

            Console.WriteLine(drawing);
        }
    }
}
