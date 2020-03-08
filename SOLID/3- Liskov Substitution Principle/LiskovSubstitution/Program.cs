using System;

namespace LiskovSubstitution
{
    class Program
    {
        /// <summary>
        /// "Objects in a program should be replaceable with instances 
        /// of their subtypes without altering the correctness of that program."
        /// 
        /// Replacing a rectangle to a square will not alter the correctness of the program. 
        /// </summary>
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine($"{rectangle} has area {Area(rectangle)}");

            Rectangle square = new Square();
            square.Width = 4;
            Console.WriteLine($"{square} has area {Area(square)}");
        }

        static public int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height; 
    }
}
